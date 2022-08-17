using FormularioDeLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FormularioDeLogin.Modelo
{
    public class Controle
    {
        public bool have;
        public String mensagem = "";
        public bool acess(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            have = loginDao.verificarLogin(login, senha);
            if(!loginDao.mensagem.Equals("")) {
                this.mensagem = loginDao.mensagem;
            }
            return have;
        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.cadastrar(email, senha, confSenha);
            if (loginDao.have) //Não precisa colocar true pois apenas .have ja significa que é true
            {
                this.have = true;
            }
            return mensagem;
        }
    }
}
