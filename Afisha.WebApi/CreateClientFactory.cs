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
                Birthday = GetBirthday()
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
            var birthday = new List<DateTime>()
            {
                new DateTime(1989,11,06),
                new DateTime(1990,10,07),
                new DateTime(1991,9,08),
                new DateTime(1992,8,09),
                new DateTime(1993,7,10),
                new DateTime(1988,6,11),
                new DateTime(1987,5,12),
                new DateTime(1986,4,13),
                
            };

            var rnd = new Random().Next(0, birthday.Count);

            return birthday[rnd];
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

    }
}
