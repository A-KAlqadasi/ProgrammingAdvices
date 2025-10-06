using System;

public class TempratureCahngedEventArgs:EventArgs
{
    public double OldTemprature { get; }
    public double NewTemprature { get; }
    public double Difference { get; }
    public TempratureCahngedEventArgs(double oldTemprature, double newTemprature)
    {
        this.OldTemprature = oldTemprature;
        this.NewTemprature = newTemprature;
        this.Difference = newTemprature - oldTemprature;
    }
}

public class Thermostat
{
    public event EventHandler<TempratureCahngedEventArgs> TempratureCahnged;

    private double _OldTemprature;
    private double _CurrentTemprature;

    public void SetTemprature(double newTemprature)
    {
        if (_CurrentTemprature != newTemprature)
        {
            _OldTemprature = _CurrentTemprature;
            _CurrentTemprature = newTemprature;

            if(TempratureCahnged != null)
                //rise the event
                OnTempratureChanged(_OldTemprature,newTemprature);
        }
    }

    public void OnTempratureChanged(double oldTemprature,double newTemprature)
    {
        OnTempratureChanged(new TempratureCahngedEventArgs(oldTemprature,newTemprature));
    }

    protected virtual void OnTempratureChanged(TempratureCahngedEventArgs e)
    {
        TempratureCahnged?.Invoke(this, e);
    }

}

public class Display
{
    public void Subscribe(Thermostat thermostat)
    {
        thermostat.TempratureCahnged += Thermostat_TempratureCahnged;
    }

    private void Thermostat_TempratureCahnged(object sender, TempratureCahngedEventArgs e)
    {
        Console.WriteLine($"\nTemprature changed");
        Console.WriteLine($"Old temprature {e.OldTemprature} C");
        Console.WriteLine($"New temprature {e.NewTemprature} C");
        Console.WriteLine($"Diffrence between tempratures {e.Difference} C");

    }


}

public class Controler
{
    public void Subscribe(Thermostat thermostat)
    {
        thermostat.TempratureCahnged += Thermostat_TempratureCahnged;
    }

    private void Thermostat_TempratureCahnged(object sender, TempratureCahngedEventArgs e)
    {
        if(e.NewTemprature >= 30)
        {
            Console.WriteLine($"\nTemprature changed\n" +
                $"New temprature is {e.NewTemprature}");
            Console.WriteLine("Air condition is on");
        }
        else
        {
            Console.WriteLine($"\nTemprature changed\n" +
                $"New temprature is {e.NewTemprature}");
            Console.WriteLine("Air condition is off");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Display display = new Display();
        Controler controler = new Controler();
        Thermostat thermostat = new Thermostat();
        display.Subscribe(thermostat);
        controler.Subscribe(thermostat);

        thermostat.SetTemprature(25);
        thermostat.SetTemprature(30);
        thermostat.SetTemprature(30);

        Console.ReadLine();
    }
}