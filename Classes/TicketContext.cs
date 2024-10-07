using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airlines_Sarksyan1.Models;
using MySql.Data.MySqlClient;

namespace Airlines_Sarksyan1.Classes
{
    public class TicketContext : Ticket
    {
        // Конструктор для инициализации данных билетов
        public TicketContext(int Price, string From, string To, DateTime StartTime, DateTime EndTime)
            : base(Price, From, To, StartTime, EndTime)
        {
        }

        // Метод для загрузки всех билетов из базы данных
        public static List<TicketContext> AllTickets()
        {
            List<TicketContext> allTickets = new List<TicketContext>();
            MySqlConnection connection = WorkingDB.OpenConnection();  // Открытие подключения
            MySqlCommand command = new MySqlCommand("SELECT * FROM `airlines`.`tickets`;", connection);  // SQL запрос
            MySqlDataReader ticketQuery = command.ExecuteReader();  // Выполнение запроса

            // Чтение данных из результата
            while (ticketQuery.Read())
            {
                allTickets.Add(new TicketContext(
                    ticketQuery.GetInt32(3),
                    ticketQuery.GetString(1),
                    ticketQuery.GetString(2),
                    ticketQuery.GetDateTime(4),
                    ticketQuery.GetDateTime(5)
                ));
            }

            connection.Close();  // Закрытие соединения
            MySqlConnection.ClearPool(connection);
            return allTickets;  // Возвращаем список билетов
        }
    }
}

