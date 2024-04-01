using AppMapper.Models;

namespace AppMapper.Repositories
{
    public class Repository
    {
        private List<Coche> coches;
        private List<Vehiculo> vehiculos;

        public Repository()
        {
            this.coches = new List<Coche>
            {
                new Coche{IdCoche=1, Marca="Toyota", Modelo="Corolla", Color="Blanco" },
                new Coche{IdCoche=2, Marca="Honda", Modelo="Civic", Color="Azul" },
                new Coche{IdCoche=3, Marca="Ford", Modelo="Mustang", Color="Rojo" },
                new Coche{IdCoche=4, Marca="Chevrolet", Modelo="Camaro", Color="Negro" }
            };
            this.vehiculos = new List<Vehiculo>
            {
                new Vehiculo{IdVehiculo=1, Marca="Yamaha", Modelo="YZF-R1", Color="Negro", TipoVehiculo="Moto" },
                new Vehiculo{IdVehiculo=3, Marca="Mercedes-Benz", Modelo="Sprinter", Color="Plata", TipoVehiculo="Furgoneta" },
                new Vehiculo{IdVehiculo=4, Marca="Volkswagen", Modelo="Crafter", Color="Verde", TipoVehiculo="Furgoneta" },
                new Vehiculo{IdVehiculo=2, Marca="Suzuki", Modelo="GSX-R1000", Color="Rojo", TipoVehiculo="Moto" },
                new Vehiculo{IdVehiculo=5, Marca="Ford", Modelo="Transit", Color="Gris", TipoVehiculo="Furgoneta" },
                new Vehiculo{IdVehiculo=6, Marca="Renault", Modelo="Master", Color="Blanco", TipoVehiculo="Furgoneta" }
            };
        }

        public List<Coche> GetCoches()
        {
            return this.coches;
        }

        public List<Vehiculo> GetVehiculos()
        {
            return this.vehiculos;
        }

        public void AgregarVehiculos(string tipoVehiculo,List<Vehiculo> vehiculos)
        {
            int siguienteid = this.vehiculos.Count + 1;
            foreach (Vehiculo vehiculo in vehiculos)
            {
                vehiculo.IdVehiculo = siguienteid;
                vehiculo.TipoVehiculo = tipoVehiculo;
                siguienteid++;
            }
            this.vehiculos.AddRange(vehiculos);
        }
    }
}
