using Afisha.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afisha.WebApi
{
    public class CreateClientFactory
    {
        public static CreateClientDto CreateMale()
        {
            var client = GetClientMale();
            return client;
        }

        public static CreateClientDto CreateFemale()
        {
            var client = GetClientFemale();
            return client;
        }

        private static CreateClientDto GetClientMale()
        {
            var client = new CreateClientDto()
            {
                FirstName = GetMaleName(),
                LastName = GetMaleLastName(),
                MiddleName = GetMaleMiddleName(),
                Birthday = GetBirthday(),
                PhoneNumber = GetNumberPhone()
            };

            return client;
        }

        private static CreateClientDto GetClientFemale()
        {
            var client = new CreateClientDto()
            {
                FirstName = GetFemaleName(),
                LastName = GetFemaleLastName(),
                MiddleName = GetFemaleMiddleName(),
                Birthday = GetBirthday()
            };

            return client;
        }
        private static string GetMaleName()
        {
            var names = new List<string>()
            {
                "Иван", 
                "Алексей", 
                "Артём", 
                "Олег", 
                "Михаил", 
                "Роман", 
                "Евгений", 
                "Виталий", 
                "Пётр", 
                "Сергей"
            };

            var rnd = new Random().Next(0, names.Count);

            return names[rnd];
        }

        private static string GetMaleLastName()
        {
            var lastNames = new List<string>()
            {
                "Гилязов",
                "Алексеев",
                "Гудь",
                "Омельченко",
                "Сурганов",
                "Иванов",
                "Путин",
                "Медведев",
                "Нитиевский",
                "Цекало"
            };

            var rnd = new Random().Next(0, lastNames.Count);

            return lastNames[rnd];
        }

        private static string GetMaleMiddleName()
        {
            var middleNames = new List<string>()
            {
                "Иванич",
                "Алексеевич",
                "Артёмович",
                "Олегович",
                "Михаилович",
                "Романович",
                "Евгеньевич",
                "Витальевич",
                "Петрович",
                "Сергеевич"
            };

            var rnd = new Random().Next(0, middleNames.Count);

            return middleNames[rnd];
        }

        private static DateTime GetBirthday()
        {
            var start = new DateTime(1950, 1, 1);
            var gen = new Random();
            var range = (DateTime.Today - start).Days;

            return start.AddDays(gen.Next(range));
        }

        private static string GetFemaleName()
        {
            var names = new List<string>()
            {
                "Ольга",
                "Анастасия",
                "Жанна",
                "Елена",
                "Татьяна",
                "Марина",
                "Екатерина",
                "Мария",
                "Ирина",
                "Алёна"
            };

            var rnd = new Random().Next(0, names.Count);

            return names[rnd];
        }

        private static string GetFemaleLastName()
        {
            var lastNames = new List<string>()
            {
                "Гилязова",
                "Алексеева",
                "Гудь",
                "Омельченко",
                "Сурганова",
                "Иванова",
                "Путина",
                "Медведева",
                "Нитиевская",
                "Цекало"
            };

            var rnd = new Random().Next(0, lastNames.Count);

            return lastNames[rnd];
        }

        private static string GetFemaleMiddleName()
        {
            var middleNames = new List<string>()
            {
                "Ивановна",
                "Алексеевна",
                "Артёмовна",
                "Олеговна",
                "Михаиловна",
                "Романовна",
                "Евгеньевна",
                "Витальевна",
                "Петровна",
                "Сергеевна"
            };

            var rnd = new Random().Next(0, middleNames.Count);

            return middleNames[rnd];
        }

        private static string GetNumberPhone()
        {
            var rnd1 = new Random().Next(1000, 9999);
            var rnd2 = new Random().Next(1111111, 9999999);

            return "+" + rnd1.ToString() + rnd2.ToString();

        }

    }
}
