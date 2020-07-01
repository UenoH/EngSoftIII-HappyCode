namespace HappyCode.Management.Core.Model
{
    public class Address
    {
        public string Cep { get; set; }
        public string Tx_Rua { get; set; }
        public string Tx_Bairro { get; set; }
        public string Tx_Municipio { get; set; }
        public string Tx_UF { get; set; }

        public static Address GetAddress(string TxCEP)
        {
            try
            {
                Address address = null;
                var end = new WsCorreios.AtendeClienteService().consultaCEP(TxCEP);
                if (end != null)
                {
                    address = new Address()
                    {
                        Cep = end.cep,
                        Tx_Rua = end.end,
                        Tx_Municipio = end.cidade,
                        Tx_Bairro = end.bairro,
                        Tx_UF = end.uf
                    };
                }
                return address;
            }
            catch
            {
                return null;
            }
        }
    }
}
