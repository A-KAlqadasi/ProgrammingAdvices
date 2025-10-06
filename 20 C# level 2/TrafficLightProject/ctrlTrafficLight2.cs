using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficLightProject.Properties;

namespace TrafficLightProject
{
    public partial class ctrlTrafficLight2 : UserControl
    {
        public enum LightEnum { Red =1, Yellow=2,Green=3}
        private LightEnum _currentLight = LightEnum.Red;
        public class TrafficLightEventArgs:EventArgs
        {
            public LightEnum CurrentLight { get; set; }
            public int DurationLight { get; set; }
            public TrafficLightEventArgs(LightEnum currentLight, int durationLight)
            {
                CurrentLight = currentLight;
                DurationLight = durationLight;
            }
        }

        public event EventHandler<TrafficLightEventArgs> RedLightOn;
        public void RaiseRedLightOn()
        {
            RedLightOn?.Invoke(this, new TrafficLightEventArgs(LightEnum.Red, _redTime));
        }

        public event EventHandler<TrafficLightEventArgs> YellowLightOn;
        public void RaiseYellowLightOn()
        {
            TrafficLightEventArgs e = new TrafficLightEventArgs(LightEnum.Yellow, _yellowTime);
            RaiseYellowLightOn(e);
        }
        protected virtual void RaiseYellowLightOn(TrafficLightEventArgs e)
        {
            YellowLightOn?.Invoke(this, e);
        }

        public event EventHandler<TrafficLightEventArgs> GreenLightOn;
        public void RaiseGreenLightOn()
        {
            RaiseGreenLightOn(new TrafficLightEventArgs(LightEnum.Green, _greenTime));
        }
        protected virtual void RaiseGreenLightOn(TrafficLightEventArgs e)
        {
            GreenLightOn?.Invoke(this, e);
        }

        private int GetTimer()
        {
            switch(_currentLight)
            {
                case LightEnum.Red:
                    return _redTime;
                case LightEnum.Green:
                    return _greenTime;
                case LightEnum.Yellow:
                    return _yellowTime;
                default:
                    return _redTime;
            }
        }

        private int _redTime =10;
        private int _yellowTime =5;
        private int _greenTime =10;

        public int RedTime
        {
            get
            {
                return _redTime;
            }
            set
            {
                _redTime= value;
            }
        }
        public int GreenTime
        {
            get
            {
                return _greenTime;
            }
            set
            {
                _greenTime = value;
            }
        }
        public int YellowTime
        {
            get
            {
                return _yellowTime;
            }
            set
            {
                _yellowTime = value;
            }
        }

        public LightEnum CurrentLight
        {
            get
            {
                return _currentLight;
            }
            set
            {
                _currentLight = value;
                switch(_currentLight)
                {
                    case LightEnum.Red:
                        pbLightImage.Image = Resources.Red;
                        lblTimerCount.ForeColor = Color.Red;
                        break;
                    case LightEnum.Green:
                        pbLightImage.Image = Resources.Green;
                        lblTimerCount.ForeColor = Color.Green;
                        break;
                    case LightEnum.Yellow:
                        pbLightImage.Image = Resources.Orange;
                        lblTimerCount.ForeColor = Color.Yellow;
                        break;
                }
            }
        }

        public ctrlTrafficLight2()
        {
            InitializeComponent();
        }
        private int _downCounter;
        public void Start()
        {
            _downCounter = GetTimer();
            LightTimer.Start();
        }
        private void LightTimer_Tick(object sender, EventArgs e)
        {
            lblTimerCount.Text = _downCounter.ToString();
            if(_downCounter == 0)
            {
                ChangeLight();
            }
            else
            {
                --_downCounter;
            }
        }
        LightEnum _lightAfterRedYellowOrGreen;
        private void ChangeLight()
        {
            switch (_currentLight)
            {
                case LightEnum.Red:
                    _lightAfterRedYellowOrGreen = LightEnum.Green;
                    CurrentLight = LightEnum.Yellow;
                    _downCounter = _yellowTime;
                    lblTimerCount.Text = _downCounter.ToString();
                    RaiseYellowLightOn();
                    break;
                case LightEnum.Yellow:
                    if (_lightAfterRedYellowOrGreen == LightEnum.Green)
                    {
                        CurrentLight = LightEnum.Green;
                        _downCounter = _greenTime;
                        lblTimerCount.Text = _downCounter.ToString();
                        RaiseGreenLightOn();
                    }
                    else
                    {
                        CurrentLight = LightEnum.Red;
                        _downCounter = _redTime;
                        lblTimerCount.Text = _downCounter.ToString();
                        RaiseRedLightOn();
                    }
                    break;
                case LightEnum.Green:
                    _lightAfterRedYellowOrGreen = LightEnum.Red;
                    CurrentLight = LightEnum.Yellow;
                    _downCounter = _yellowTime;
                    lblTimerCount.Text = _downCounter.ToString();
                    RaiseYellowLightOn();
                    break;
                
            }
        }
    }
}
