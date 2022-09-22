using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace persistencia
{
    public class RepositorioTecnico: IRepositorioTecnico
    {
        private readonly ApplicationContext _applicationContext;

        public RepositorioTecnico(ApplicationContext applicationContext){
            _applicationContext = applicationContext;
        }

        Tecnico IRepositorioTecnico.Add(Tecnico tecnico){
            var new_tecnico = _applicationContext.tecnicos.Add(tecnico); //tecnicos es la tabla, tecnico es el objeto
            _applicationContext.SaveChanges();
            return new_tecnico.Entity;
        }

        void IRepositorioTecnico.Delete(int IdTecnico){
            var tecnicoEncontrada = _applicationContext.tecnicos.FirstOrDefault(
                p => p.Id == IdTecnico
            );

            if(tecnicoEncontrada == null){
                return;
            }
            else{
                _applicationContext.Remove(tecnicoEncontrada);
                _applicationContext.SaveChanges();
            }
        }//Fin delete

        IEnumerable<Tecnico> IRepositorioTecnico.GetAll(){
            return _applicationContext.tecnicos;
        }//Fin getall

        Tecnico IRepositorioTecnico.Get(int idTecnico){
                return _applicationContext.tecnicos.FirstOrDefault(
                    p => p.Id == idTecnico
                );
        }//Fin get

        Tecnico IRepositorioTecnico.Update(Tecnico tecnico){
            var tecnicoEncontrada = _applicationContext.tecnicos.FirstOrDefault(
                p => p.Id == tecnico.Id
            );

            if(tecnicoEncontrada !=null){
                tecnicoEncontrada.Nombre_Tec = tecnico.Nombre_Tec;
                tecnicoEncontrada.Rev_filtroAire = tecnico.Rev_filtroAire;
                tecnicoEncontrada.Rev_filtroGas = tecnico.Rev_filtroGas;
                tecnicoEncontrada.Rev_aceite = tecnico.Rev_aceite;
                tecnicoEncontrada.Cam_Repuesto = tecnico.Cam_Repuesto;
                tecnicoEncontrada.Descripcion = tecnico.Descripcion;
            }
            _applicationContext.SaveChanges();
            return tecnicoEncontrada;

        }
    }
}