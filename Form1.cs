using System;
using System.Globalization;
using System.Windows.Forms;

namespace PolySolve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Функция для вычисления кубического корня, корректно обрабатывающая отрицательные числа
        public static double Cbrt(double x)
        {
            if (x >= 0)
            {
                return Math.Pow(x, 1.0 / 3.0);
            }
            else
            {
                return -Math.Pow(-x, 1.0 / 3.0);
            }
        }

        private void buttonSolveQuadratic_Click(object sender, EventArgs e)
        {
            double a, b, c;
            string errorMessage = "";

            if (!double.TryParse(textBoxAQuadratic.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out a))
            {
                errorMessage += "Ошибка: Неверный формат числа в поле a.\n";
            }
            else if (a == 0)
            {
                errorMessage += "Ошибка: a не может быть равно 0. Уравнение становится линейным.\n";
            }

            if (!double.TryParse(textBoxBQuadratic.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out b))
            {
                errorMessage += "Ошибка: Неверный формат числа в поле b.\n";
            }

            if (!double.TryParse(textBoxCQuadratic.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out c))
            {
                errorMessage += "Ошибка: Неверный формат числа в поле c.\n";
            }

            if (!string.IsNullOrEmpty(errorMessage))
            {
                labelQuadraticResult.Text = errorMessage;
                return;
            }

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                labelQuadraticResult.Text = $"x1 = {x1:F6}\n x2 = {x2:F6}";
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                labelQuadraticResult.Text = $"x = {x:F6}";
            }
            else
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(Math.Abs(discriminant)) / (2 * a);
                labelQuadraticResult.Text = $"x1 = {realPart:F6} + {imaginaryPart:F6}i\n x2 = {realPart:F6} - {imaginaryPart:F6}i";
            }
        }

        private void buttonSolveCubic_Click(object sender, EventArgs e)
        {
            double a, b, c, d;
            string errorMessage = "";

            if (!double.TryParse(textBoxACubic.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out a))
            {
                errorMessage += "Ошибка: Неверный формат числа в поле a.\n";
            }
            else if (a == 0)
            {
                errorMessage += "Ошибка: a не может быть равно 0. Уравнение становится квадратным.\n";
            }

            if (!double.TryParse(textBoxBCubic.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out b))
            {
                errorMessage += "Ошибка: Неверный формат числа в поле b.\n";
            }

            if (!double.TryParse(textBoxCCubic.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out c))
            {
                errorMessage += "Ошибка: Неверный формат числа в поле c.\n";
            }

            if (!double.TryParse(textBoxDCubic.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out d))
            {
                errorMessage += "Ошибка: Неверный формат числа в поле d.\n";
            }

            if (!string.IsNullOrEmpty(errorMessage))
            {
                labelCubicResult.Text = errorMessage;
                return;
            }

            // Нормализация: делим все коэффициенты на 'a'
            b /= a;
            c /= a;
            d /= a;
            a = 1; // Теперь a = 1

            double Q = (3 * c - b * b) / 9;
            double R = (9 * b * c - 27 * d - 2 * b * b * b) / 54;
            double delta = Q * Q * Q + R * R;

            if (delta >= 0)
            {
                // Один действительный корень и два комплексных сопряженных (или три действительных, но есть кратные)
                double S = Cbrt(R + Math.Sqrt(delta));
                double T = Cbrt(R - Math.Sqrt(delta));

                double x1 = S + T - b / 3;
                double realPart = -(S + T) / 2 - b / 3;
                double imagPart = (S - T) * Math.Sqrt(3) / 2;

                labelCubicResult.Text = $"x1 = {x1:F6}\n" +
                                        $"x2 = {realPart:F6} + {imagPart:F6}i\n" +
                                        $"x3 = {realPart:F6} - {imagPart:F6}i";
            }
            else
            {
                // Три действительных корня (неприводимый случай)
                double theta = Math.Acos(R / Math.Sqrt(-Q * Q * Q));

                double x1 = 2 * Math.Sqrt(-Q) * Math.Cos(theta / 3) - b / 3;
                double x2 = 2 * Math.Sqrt(-Q) * Math.Cos((theta + 2 * Math.PI) / 3) - b / 3;
                double x3 = 2 * Math.Sqrt(-Q) * Math.Cos((theta + 4 * Math.PI) / 3) - b / 3;

                labelCubicResult.Text = $"x1 = {x1:F6}\n x2 = {x2:F6}\n x3 = {x3:F6}";
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            string helpText = "Программа PolySolve решает квадратные и кубические уравнения.\n\n" +
                              "**Квадратные уравнения:**\n" +
                              "Введите коэффициенты a, b и c в соответствующие поля.\n" +
                              "Уравнение имеет вид: ax² + bx + c = 0\n\n" +
                              "**Кубические уравнения:**\n" +
                              "Введите коэффициенты a, b, c и d в соответствующие поля.\n" +
                              "Уравнение имеет вид: ax³ + bx² + cx + d = 0\n\n" +
                              "**Формат ввода чисел:**\n" +
                              "Используйте точку (.) в качестве десятичного разделителя.\n\n" +
                              "**Отображение корней:**\n" +
                              "Программа вычисляет все корни (действительные и комплексные) для квадратных и кубических уравнений.";

            MessageBox.Show(helpText, "Использование программы PolySolve", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonClearQuadratic_Click(object sender, EventArgs e)
        {
            // Очистка полей ввода для квадратных уравнений
            textBoxAQuadratic.Text = "";
            textBoxBQuadratic.Text = "";
            textBoxCQuadratic.Text = "";
            labelQuadraticResult.Text = "";
        }

        private void buttonClearCubic_Click(object sender, EventArgs e)
        {
            // Очистка полей ввода для кубических уравнений
            textBoxACubic.Text = "";
            textBoxBCubic.Text = "";
            textBoxCCubic.Text = "";
            textBoxDCubic.Text = "";
            labelCubicResult.Text = "";
        }
    }
}