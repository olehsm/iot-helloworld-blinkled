using System.Device.Gpio;

Console.WriteLine("Blinking LED. Press Ctrl+C to end.");

const int gpioPinNumber = 4;
bool isLedOn = true;

using var gpioController = new GpioController();
gpioController.OpenPin(gpioPinNumber, PinMode.Output);

while (true)
{
    gpioController.Write(gpioPinNumber, isLedOn ? PinValue.High : PinValue.Low);
    Thread.Sleep(1500);
    isLedOn = !isLedOn;
}

//gpioController.ClosePin(gpioPinNumber);

