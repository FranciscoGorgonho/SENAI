using BE7_FS4_UC9.Interfaces;
using System.Text.RegularExpressions;

namespace BE7_FS4_UC9.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj { get; set; }
        public string? razaoSocial { get; set; }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {
            if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            { // xx.xxx.xxx/xxxx-xx ou xxxxxxxxxxxxxx
                if (cnpj.Length == 18)
                {
                    if (cnpj.Substring(11, 4) == "0001")
                    {// após as 11 verifica as proxima 4 casas
                        return true;
                    }
                }
                else if (cnpj.Length == 14)
                {
                    if (cnpj.Substring(8, 4) == "0001")
                    {// após as 11 verifica as proxima 4 casas
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
