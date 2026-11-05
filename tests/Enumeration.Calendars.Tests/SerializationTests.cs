using System.Runtime.Serialization;

namespace CloudyWing.Enumeration.Calendars.Tests {
    internal class SerializationTests {
        [Test]
        public void DataContractSerializer_MonthRoundTrip_ReturnsDeclaredInstance() {
            Month actual = RoundTripWithDataContract(Month.March);

            Assert.That(actual, Is.SameAs(Month.March));
        }

        [Test]
        public void DataContractSerializer_WeekDayRoundTrip_ReturnsDeclaredInstance() {
            WeekDay actual = RoundTripWithDataContract(WeekDay.Friday);

            Assert.That(actual, Is.SameAs(WeekDay.Friday));
        }

#if NETFRAMEWORK
        [Test]
        public void BinaryFormatter_MonthRoundTrip_ReturnsDeclaredInstance() {
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new();
            using MemoryStream stream = new();

            formatter.Serialize(stream, Month.March);
            stream.Position = 0;
            object actual = formatter.Deserialize(stream);

            Assert.That(actual, Is.SameAs(Month.March));
        }
#endif

        private static T RoundTripWithDataContract<T>(T value) {
            DataContractSerializer serializer = new(typeof(T));
            using MemoryStream stream = new();

            serializer.WriteObject(stream, value);
            stream.Position = 0;

            return (T)serializer.ReadObject(stream)!;
        }
    }
}
