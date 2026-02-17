namespace ProyectoPOO
{
    public class CuentaBancaria
    {
        // Atributo privado:
        // Solo puede ser modificado dentro de la clase
        // Esto es encapsulamiento
        private decimal saldo;

        // Método público para depositar dinero
        // Se suma el monto al saldo actual
        public void Depositar(decimal monto)
        {
            saldo += monto;
        }

        // Método público para consultar el saldo
        // No permite modificarlo directamente
        public decimal ObtenerSaldo()
        {
            return saldo;
        }
    }
}
