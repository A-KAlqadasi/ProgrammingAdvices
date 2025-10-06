using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficLightProject.Properties;

namespace TrafficLightProject
{
   

    public partial class ctrlTrafficLight : UserControl
    {

        public enum LightEnum { Red = 1, Yellow = 2, Green = 3 }
        LightEnum _CurrentLight = LightEnum.Red;

        public class TrafficLightEventArgs : EventArgs
        {
            public LightEnum CurrentLight { get; set; }
            public int LightDuration { get; set; }
            public TrafficLightEventArgs(LightEnum currentLight, int lightDuration)
            {
                this.LightDuration = lightDuration;
                this.CurrentLight = currentLight;
            }
        }

        public event EventHandler<TrafficLightEventArgs> RedLightOn;
        
        public void RaisRedLightOn()
        {
            RaisRedLightOn(new TrafficLightEventArgs(LightEnum.Red, _RedTime));
        }
        protected virtual void RaisRedLightOn(TrafficLightEventArgs e)
        {
            RedLightOn?.Invoke(this, e);
        }

        public event EventHandler<TrafficLightEventArgs> YellowLightOn;

        public void RaisYellowLightOn()
        {
            RaisYellowLightOn(new TrafficLightEventArgs(LightEnum.Yellow, _YelloTime));
        }
        protected virtual void RaisYellowLightOn(TrafficLightEventArgs e)
        {
            YellowLightOn?.Invoke(this, e);
        }

        public event EventHandler<TrafficLightEventArgs> GreenLightOn;
        public void RaisGreenLightOn()
        {
            RaisGreenLightOn(new TrafficLightEventArgs(LightEnum.Green,_GreenTime));
        }
        protected virtual void RaisGreenLightOn(TrafficLightEventArgs e)
        {
            GreenLightOn?.Invoke(this, e);
        }

        private int _RedTime = 10;
        private int _YelloTime = 3;
        private int _GreenTime = 10;

        public int RedTime
        {
            get { return _RedTime; }
            set
            {
                _RedTime = value;
            }
        }
        public int YellowTime
        {
            get { return _YelloTime; }
            set
            {
                _YelloTime = value;
            }
        }

        public int GreenTime
        {
            get { return _GreenTime; }
            set
            {
                _GreenTime = value;
            }
        }
        public LightEnum CurrentLight
        {
            get
            {
                return _CurrentLight;

            }
            set
            {
                _CurrentLight = value;
                switch (_CurrentLight)
                {
                    case LightEnum.Red:
                        pbLightImage.Image = Resources.Red;
                        lblTimerCount.ForeColor = Color.Red;
                        break;
                    case LightEnum.Yellow:
                        pbLightImage.Image = Resources.Orange;
                        lblTimerCount.ForeColor = Color.Yellow;
                        break;
                    case LightEnum.Green:
                        pbLightImage.Image = Resources.Green;
                        lblTimerCount.ForeColor = Color.Green;
                        break;
                    default:
                        pbLightImage.Image = Resources.Red;
                        break;
                }
            }
        }
        private int GetTimer()
        {
            switch (_CurrentLight)
            {
                case LightEnum.Red:
                    return _RedTime;
                case LightEnum.Yellow:
                    return _YelloTime;
                case LightEnum.Green:
                    return _GreenTime;
                default: return _RedTime;
            }
        }
        int _DownCounter;
        public void Start()
        {
            _DownCounter =GetTimer();
            LightTimer.Start();
        }
        public void Stop()
        {
            LightTimer.Stop();
        }

        public ctrlTrafficLight()
        {
            InitializeComponent();
        }

        private void LightTimer_Tick(object sender, EventArgs e)
        {
            lblTimerCount.Text = _DownCounter.ToString();
            if(_DownCounter ==0)
            {
                _ChangeLight();
            }
            else
            {
                --_DownCounter;
            }
        }
        LightEnum _LightAfterRedYellowOrGreen;

        private void _ChangeLight()
        {
            switch(_CurrentLight)
            {
                case LightEnum.Red:
                    _LightAfterRedYellowOrGreen = LightEnum.Green;
                    CurrentLight = LightEnum.Yellow;
                    _DownCounter = YellowTime;
                    lblTimerCount.Text = _DownCounter.ToString();
                    RaisYellowLightOn();
                    break;
                case LightEnum.Yellow:
                    if(_LightAfterRedYellowOrGreen == LightEnum.Green)
                    {
                        CurrentLight = LightEnum.Green;
                        _DownCounter = GreenTime;
                        lblTimerCount.Text = _DownCounter.ToString();
                        RaisGreenLightOn();
                    }
                    else
                    {
                        CurrentLight = LightEnum.Red;
                        _DownCounter = RedTime;
                        lblTimerCount.Text =_DownCounter.ToString();
                        RaisRedLightOn();
                    }
                    break;
                case LightEnum.Green:
                    _LightAfterRedYellowOrGreen = LightEnum.Red;
                    CurrentLight = LightEnum.Yellow;
                    _DownCounter = YellowTime;
                    lblTimerCount.Text = _DownCounter.ToString();
                    RaisYellowLightOn();
                    break;

            }
        }

    }
}
