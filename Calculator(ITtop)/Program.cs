using Terminal.Gui;

namespace Calculator_ITtop_
{
    public class Program
    {
        internal static Toplevel top;

        private static void Main(string[] args)
        {
            Application.Init();
            top = Application.Top;

            UI.Interface();

            Application.Run();
        }
    }

    public class UI : Program
    {
        private static TextField field;

        public static void Interface()
        {
            var win = new Window("CALCULATOR");

            var calculator = new FrameView()
            {
                X = Pos.Center(),
                Y = Pos.Center(),
                Width = 35,
                Height = 25
            };

            field = new TextField()
            {
                X = Pos.Center(),
                Y = Pos.Center() - 9,
                Width = 30
            };

            var one = new Button("1")
            {
                X = Pos.Center() - 10,
                Y = Pos.Center(),
            };
            one.Clicked += () => OnButtonClicked("1");

            var two = new Button("2")
            {
                X = Pos.Center(),
                Y = Pos.Center(),
            };
            two.Clicked += () => OnButtonClicked("2");

            var three = new Button("3")
            {
                X = Pos.Center() + 6,
                Y = Pos.Center(),
            };
            three.Clicked += () => OnButtonClicked("3");

            var four = new Button("4")
            {
                X = Pos.Center() - 10,
                Y = Pos.Center() + 3,
            };
            four.Clicked += () => OnButtonClicked("4");

            var five = new Button("5")
            {
                X = Pos.Center(),
                Y = Pos.Center() + 3,
            };
            five.Clicked += () => OnButtonClicked("5");

            var six = new Button("6")
            {
                X = Pos.Center() + 6,
                Y = Pos.Center() + 3,
            };
            six.Clicked += () => OnButtonClicked("6");

            var seven = new Button("7")
            {
                X = Pos.Center() - 10,
                Y = Pos.Center() + 6,
            };
            seven.Clicked += () => OnButtonClicked("7");

            var eight = new Button("8")
            {
                X = Pos.Center(),
                Y = Pos.Center() + 6,
            };
            eight.Clicked += () => OnButtonClicked("8");

            var nine = new Button("9")
            {
                X = Pos.Center() + 6,
                Y = Pos.Center() + 6,
            };
            nine.Clicked += () => OnButtonClicked("9");

            var delete = new Button("C")
            {
                X = Pos.Center() - 10,
                Y = Pos.Center() + 9,
            };
            delete.Clicked += () => OnButtonClicked("C");

            var zero = new Button("0")
            {
                X = Pos.Center(),
                Y = Pos.Center() + 9,
            };
            zero.Clicked += () => OnButtonClicked("0");

            var comma = new Button(",")
            {
                X = Pos.Center() + 6,
                Y = Pos.Center() + 9,
            };
            comma.Clicked += () => OnButtonClicked(",");

            var plus = new Button("+")
            {
                X = Pos.Center() - 10,
                Y = Pos.Center() - 3,
            };
            plus.Clicked += () => OnButtonClicked("+");

            var minus = new Button("-")
            {
                X = Pos.Center(),
                Y = Pos.Center() - 3,
            };
            minus.Clicked += () => OnButtonClicked("-");

            var multi = new Button("*")
            {
                X = Pos.Center() + 6,
                Y = Pos.Center() - 3,
            };
            multi.Clicked += () => OnButtonClicked("*");

            var div = new Button("/")
            {
                X = Pos.Center() - 10,
                Y = Pos.Center() - 6,
            };
            div.Clicked += () => OnButtonClicked("/");

            var degree = new Button("^")
            {
                X = Pos.Center(),
                Y = Pos.Center() - 6,
            };
            degree.Clicked += () => OnButtonClicked("^");

            var equally = new Button("=")
            {
                X = Pos.Center() + 6,
                Y = Pos.Center() - 6,
            };
            equally.Clicked += () => OnButtonClicked("=");

            calculator.Add(one, two, three, four, five, six, seven, eight, nine, zero,
                delete, comma, plus, minus, multi, div, degree, equally, field);

            win.Add(calculator);
            top.Add(win);
        }

        private static void OnButtonClicked(string label)
        {
            if (label == "C") field.Text = string.Empty;
            else if (label == "=")
            {
                string expression = field.Text.ToString().Replace(",", ".");
                field.Text = Source.Evaluate(expression);
            }
            else field.Text += label;
        }
    }
}
