using System;
using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;

namespace firstTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new TelegramBotClient("6359488045:AAEyUGIsCd_BIISoxiTMp2ZB4UpCPXsGm5c");
            client.StartReceiving(Update, Error);
            Console.ReadLine();
        }

        async static Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
        {
            var message = update.Message;
            if (message.Text != null)
            {
                if (message.Text.ToLower().Contains("новинки"))
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Atomic Heart");

                    var foto = "https://pic.rutubelist.ru/video/e2/3d/e23da4c7e325a91dd6a40c30c1548e56.jpg";
                    InputFileUrl inputOnlineFile = new(foto);
                    await botClient.SendPhotoAsync(message.Chat.Id, inputOnlineFile);

                    await botClient.SendTextMessageAsync(message.Chat.Id, "Ссылка на трейлер игры \r\n https://www.youtube.com/watch?v=1ZeDVEvjWPI");

                    await botClient.SendTextMessageAsync(message.Chat.Id, "Описание игры: \r\nAtomic Heart — приключенческий ролевой боевик с открытым миром, действие которого разворачивается в альтернативном Советском Союзе 1955 года. Наука, равенство и братство — вот основные символы Свободы этой реальности.\r\nПлатформы: Windows, Xbox Series X/S, PlayStation 5, Xbox One, PlayStation 4 \r\nРежим: Однопользовательская игра\r\nРазработчик: Mundfish\r\nЖанр: Шутер от первого лица\r\nСайт: mundfish.com");


                    await botClient.SendTextMessageAsync(message.Chat.Id, "Cities: Skylines 2");

                    var foto1 = "https://static0.gamerantimages.com/wordpress/wp-content/uploads/2023/10/cities-skylines-2.jpg";
                    InputFileUrl inputOnlineFile1 = new(foto1);
                    await botClient.SendPhotoAsync(message.Chat.Id, inputOnlineFile1);

                    await botClient.SendTextMessageAsync(message.Chat.Id, "Ссылка на трейлер игры \r\n https://youtu.be/yDkRbkLGXp0");

                    await botClient.SendTextMessageAsync(message.Chat.Id, "Описание игры: \r\nCities: Skyline 2 - это сиквел градостроительного симулятора, в котором разработчики улучшили симуляцию жизни в городе, экономическую систему и многое другое. Как и оригинал, Skyline 2 предлагает построить город своей мечты, полный разнообразных районов, дорожных развязок, технических построек и тому подобных вещей.\r\nПлатформы: PC, PlayStation 5, Xbox Series X/S\r\nЖанры: Стратегии, Симуляторы\r\nИздатель: Paradox Interactive\r\nРазработчик: Colossal Order");


                    await botClient.SendTextMessageAsync(message.Chat.Id, "Lies of P");

                    var foto2 = "https://i.playground.ru/e/pRkSBG1Ij_X8vu_nLW4qLg.png";
                    InputFileUrl inputOnlineFile2 = new(foto2);
                    await botClient.SendPhotoAsync(message.Chat.Id, inputOnlineFile2);

                    await botClient.SendTextMessageAsync(message.Chat.Id, "Ссылка на трейлер игры \r\n https://youtu.be/5a5JZVf0Xsk");

                    await botClient.SendTextMessageAsync(message.Chat.Id, "Описание игры: \r\nLies of P - это приключенческая ролевая игра, вдохновленная сериями Dark Souls, Bloodborne и сказкой о Пиноккио. События Lies of P разворачиваются в городе Кратт, вдохновленной концом XIX - началом XX века в Европе. Главный герой игры - Пиноккио, механоид-марионетка, который должен отыскать мистера Джеппетто в городе, утопающем в безумии и жажде крови. Игроки помогают Пиноккио с его нелегким поручением, сражаясь с разнообразными противниками, выполняя необязательные поручения, создавая новые виды оружия и изменяя внешний вид и навыки своего героя. Также игроков ждет уникальная \"система лжи\", которая позволяет тем или иным образом разбираться с заданиями - что, в свою очередь, влияет на концовку игры.\r\nПлатформы: PC, PlayStation 5, Xbox Series X/S\r\nЖанры: Экшен, RPG (РПГ)\r\nИздатель: NeoWiz\r\nРазработчик: Round8 Studio");

                    return;
                }
            }
        }

        static async Task Error(ITelegramBotClient bot, Exception exception, CancellationToken cancellationToken)
        {
            try
            {
                // Ваш код здесь
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}