using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace persistencia
{
    public class RepositorioCarro: IRepositorioCarro
    {
        private readonly ApplicationContext _applicationContext;

        public RepositorioCarro(ApplicationContext applicationContext){
            _applicationContext = applicationContext;
        }

        Carro IRepositorioCarro.Add(Carro Carro){
            var new_carro = _applicationContext.carros.Add(Carro); //carros es la tabla, Carro es el objeto
            _applicationContext.SaveChanges();
            return new_carro.Entity;
        }

        void IRepositorioCarro.Delete(int IdCarro){
            var carroEncontrada = _applicationContext.carros.FirstOrDefault(
                p => p.Id == IdCarro
            );

            if(carroEncontrada == null){
                return;
            }
            else{
                _applicationContext.Remove(carroEncontrada);
                _applicationContext.SaveChanges();
            }
        }//Fin delete

        IEnumerable<Carro> IRepositorioCarro.GetAll(){
            return _applicationContext.carros;
        }//Fin getall

        Carro IRepositorioCarro.Get(int idCarro){
                return _applicationContext.carros.FirstOrDefault(
                    p => p.Id == idCarro
                );
        }//Fin get

        Carro IRepositorioCarro.Update(Carro Carro){
            var carroEncontrada = _applicationContext.carros.FirstOrDefault(
                p => p.Id == Carro.Id
            );

            if(carroEncontrada !=null){
                carroEncontrada.Placa = Carro.Placa;
                carroEncontrada.Marca = Carro.Marca;
                carroEncontrada.Modelo = Carro.Modelo;
                carroEncontrada.Color = Carro.Color;
            }
            _applicationContext.SaveChanges();
            return carroEncontrada;

        }
    }
}