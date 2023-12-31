﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace stalcraft_observer
{
    internal class HTTPrequest// Класс запросы с помощью HTTP протокола
    {
        //Поле HttpClient, единственное для всех объектов
        static HttpClient httpClient = new HttpClient();

        //Принимает название предмета, возвращает строку в формате Json
        public static async Task<string> get(string item) { 
            using HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://eapi.stalcraft.net/ru/auction/{item}/history"),
                Headers =
                {
                    { "Client-id", "" },
                    { "Client-Secret", "" }
                }
            };
            using (var response = await httpClient.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return body;
            }
        }

    }
}
