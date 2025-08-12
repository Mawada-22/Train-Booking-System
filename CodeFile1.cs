using System;
using System.Data;
using System.Data.SqlClient;

namespace TrainBookingSystem
{
    public class TrainBookingSystemReport
    {
        private readonly string connectionString;

        public TrainBookingSystemReport(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void SignUpNewUser(string firstName, string lastName, string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Users (FirstName, LastName, Email, Password) VALUES (@FirstName, @LastName, @Email, @Password)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateUserDetails(int userId, string firstName, string lastName, string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Users SET FirstName = @FirstName, LastName = @LastName, Email = @Email WHERE UserId = @UserId";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Email", email);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddTrain(string trainNumber, string trainName, int capacity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Trains (TrainNumber, TrainName, Capacity) VALUES (@TrainNumber, @TrainName, @Capacity)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@TrainNumber", trainNumber);
                    command.Parameters.AddWithValue("@TrainName", trainName);
                    command.Parameters.AddWithValue("@Capacity", capacity);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTrainDetails(int trainId, string trainNumber, string trainName, int capacity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Trains SET TrainNumber = @TrainNumber, TrainName = @TrainName, Capacity = @Capacity WHERE TrainId = @TrainId";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@TrainId", trainId);
                    command.Parameters.AddWithValue("@TrainNumber", trainNumber);
                    command.Parameters.AddWithValue("@TrainName", trainName);
                    command.Parameters.AddWithValue("@Capacity", capacity);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddTrip(string tripNumber, DateTime time, string source, string destination, int trainId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Trips (TripNumber, Time, Source, Destination, TrainId) VALUES (@TripNumber, @Time, @Source, @Destination, @TrainId)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@TripNumber", tripNumber);
                    command.Parameters.AddWithValue("@Time", time);
                    command.Parameters.AddWithValue("@Source", source);
                    command.Parameters.AddWithValue("@Destination", destination);
                    command.Parameters.AddWithValue("@TrainId", trainId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTripDetails(int tripId, string tripNumber, DateTime time, string source, string destination, int trainId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Trips SET TripNumber = @TripNumber, Time = @Time, Source = @Source, Destination = @Destination, TrainId = @TrainId WHERE TripId = @TripId";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@TripId", tripId);
                    command.Parameters.AddWithValue("@TripNumber", tripNumber);
                    command.Parameters.AddWithValue("@Time", time);
                    command.Parameters.AddWithValue("@Source", source);
                    command.Parameters.AddWithValue("@Destination", destination);
                    command.Parameters.AddWithValue("@TrainId", trainId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAvailableSeats(DateTime date, TimeSpan time, string source, string destination, int requiredSeats)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = @"SELECT t.TripId, t.TripNumber, t.Time, t.Source, t.Destination, t.Date, t.Available_NormalSeats, t.Available_VIPSeats, tr.TrainNumber
                                      FROM Trips AS t
                                      INNER JOIN Trains AS tr ON t.TrainId = tr.TrainId
                                      WHERE t.Date = @Date
                                      AND t.Time = @Time
                                      AND t.Source = @Source
                                      AND t.Destination = @Destination
                                      AND t.Available_NormalSeats + t.Available_VIPSeats >= @RequiredSeats";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Date", date.Date);
                    command.Parameters.AddWithValue("@Time", time);
                    command.Parameters.AddWithValue("@Source", source);
                    command.Parameters.AddWithValue("@Destination", destination);
                    command.Parameters.AddWithValue("@RequiredSeats", requiredSeats);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public void BookSeat(int tripId, int seatsToBook)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Trips SET Available_NormalSeats = Available_NormalSeats - @SeatsToBook WHERE TripId = @TripId";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@TripId", tripId);
                    command.Parameters.AddWithValue("@SeatsToBook", seatsToBook);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void CancelSeatBooking(int tripId, int seatsToCancel)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Trips SET Available_NormalSeats = Available_NormalSeats + @SeatsToCancel WHERE TripId = @TripId";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@TripId", tripId);
                    command.Parameters.AddWithValue("@SeatsToCancel", seatsToCancel);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
