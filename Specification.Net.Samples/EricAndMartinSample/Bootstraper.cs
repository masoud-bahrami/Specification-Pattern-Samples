using System;
using System.Collections.Generic;
using Specification.Net.Samples.EricAndMartinSample.DomainObject;
using Specification.Net.Samples.EricAndMartinSample.Specifications;

namespace Specification.Net.Samples.EricAndMartinSample
{
    internal class Bootstraper
    {
        static List<Container> _containers; 
        static List<Cargo> _cargoes; 
        public static void Run()
        {
            Initialize();
            GenerateContainers();
            GenerateCargos();
            AssignContainerForCargos();
        }

        private static void AssignContainerForCargos()
        {
            foreach (var cargo in _cargoes)
            {
                Console.WriteLine($"Cargo Id={cargo.Id} , Name={cargo.Name}");
                foreach (var container in _containers)
                {
                    Console.Write($"Container Id{container.Id} ");
                    Console.WriteLine(cargo.StorageSpecification.IsSatisfiedBy(container) ? "IsOkay" : "IsNotOkay");
                }
                Console.WriteLine("-----------------------------------");
            }
        }

        private static void GenerateCargos()
        {
            //Using Strategy Pattern for Storage Specification
            _cargoes.Add(new Cargo(new MeatStorageSpecification())
            {
                Id = 1,
                Name = "Meat",
                Weight = 20
            });

            _cargoes.Add(new Cargo(new VegtableStorageSpecification())
            {
                Id = 2,
                Name = "Vegtable",
                Weight = 30
            });

            _cargoes.Add(new Cargo(new ParameterizedStorageSpecification(3,2))
            {
                Id = 2,
                Name = "Milk",
                Weight = 20
            });

        }

        private static void GenerateContainers()
        {
            for (var i = 0; i < 10; i++)
            {
                _containers.Add(new Container
                {
                    Id = i,
                    MaxWeight = i*2,
                    HasRefrigerator = i/2 == 0,
                    InternalTemperature = i-1
                });
            }
        }

        private static void Initialize()
        {
            _containers = new List<Container>();
            _cargoes = new List<Cargo>();
        }
    }
}
