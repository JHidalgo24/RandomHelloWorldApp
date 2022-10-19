using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorldApp
{
    public partial class MainPage : ContentPage
    {
        
        private readonly string[] _helloList = {"Hello World","Hola Mundo","Bonjour le monde","Hallo Welt","Ciao mondo", "你好世界", "Olá Mundo","こんにちは世界"};
        private int _greetingNum = 1;
        private Random _random = new Random();
        public MainPage()
        {
            InitializeComponent();
            GreetingLabel.Text = _helloList[_greetingNum];
            Color color = Color.FromRgb(_random.Next(256), _random.Next(256), _random.Next(256));
        }
        void Handle_Greeting(object sender, System.EventArgs e)
        {
            
            var num = _random.Next(0, 8);
            if (_greetingNum == num)
            {
                switch (_greetingNum)
                {
                    //prevents it from being helloList[7] twice
                    case 7:
                        num--;
                        break;
                    //prevents it from being helloList[0] twice
                    case 0:
                        num++;
                        break;
                    //prevents it from being the same number twice and either goes up or down randomly
                    default:
                    {
                        if ((num + _random.Next(0,1000)) % 2 == 0)
                            num--;
                        else
                            num++;
                        break;
                    }
                }
            }
            
            
            _greetingNum = num;
            CurrentGreeting.Text = $"Greeting {num + 1} of {_helloList.Length}";
            GreetingLabel.Text = _helloList[_greetingNum];
            Color color = Color.FromRgb(_random.Next(256), _random.Next(256), _random.Next(256));

            GreetingLabel.TextColor = color;
        }
        

    }
}