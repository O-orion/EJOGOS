using EJOGOS.Models;
using System.Collections.Generic;

namespace EJOGOS.Interface
{
    public interface IEquipes
    {

        public void CriaEquipe(Equipe NovaEquipe);

        public List<Equipe> ListaEquipes();
    }
}
