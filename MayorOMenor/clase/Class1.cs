namespace MayorOMenor
{
    public class MayorOMenor
    {
        public void MayorMenor()
        {
            int num1 = 0;
            int num2 = 0;
            decimal suma = 0;
            decimal diferencia = 0;
            decimal producto = 0;
            decimal division = 0;

            try
            {
                Console.WriteLine("Ingrese su primer numero: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su segundo numero: ");
                num2 = int.Parse(Console.ReadLine());

                if (num1 > num2)
                {
                    suma = (num1 + num2);
                    diferencia = (num1 - num2);

                    Console.WriteLine($"La suma de sus dos numeros es: {suma}");
                    Console.WriteLine($"La diferencia de sus dos numeros es: {diferencia}");

                }

                else
                {
                    producto = (num1 * num2);
                    division = ((decimal)num1 / num2);

                    Console.WriteLine($"El producto de sus dos numeros es: {producto}");
                    Console.WriteLine($"La division de sus dos numeros es: {division}");

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");

            }

        }
    }

}
