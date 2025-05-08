using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text.Json.Serialization;
using System.Transactions;

namespace RodriguezJ_MiPrimeraAPI.Models
{
    public class Cuenta
    {
        [Key]
        public int NumeroCuenta { get; set; }
        [JsonIgnore]
        public TipoCuenta TipoCuenta { get; set; }
        public string NombreTipoCuenta
        {
            get 
            {
                return TipoCuenta.ToString();
            }
        }
        public double Saldo { get; set; }


    }

    public enum TipoCuenta
    {
        Ahorros,
        Corriente
    }
}
