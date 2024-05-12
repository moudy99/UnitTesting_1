using CarFactoryLibrary;

namespace CarFactoryLibaray_Lap1_test
{
    public class BMW_Tests
    {
        [Fact]
        public void IsStopped_Velocity0_true()
        {
            //A 1
            BMW bmw = new BMW();
            bmw.velocity = 0;
            //A 2
            bool carStoped = bmw.IsStopped();
            //A 3
            Assert.True(carStoped);
        }
        [Fact]
        public void IncreaseVelocity_velocity500Add100_600()
        {
            //A 1
            BMW bmw = new BMW();
            bmw.velocity = 500;
            double AddedVelocity = 100;
            //A 2
            bmw.IncreaseVelocity(AddedVelocity);
            //A 3
            Assert.Equal(600, bmw.velocity);
        }
        [Fact]
        public void GetMyCar_callFunction_SameCar()
        {
            //A 1
            BMW bmw = new BMW();
            //A 2
            Car car = bmw.GetMyCar();
            //A 3
            Assert.Same(bmw, car);
        }

        [Fact]
        public void TimeToCoverDistance_distance100_Velocity50_2()
        {
            //A 1
            BMW bmw = new BMW();
            bmw.velocity = 50;
            double distance = 100;
            //A 2
            double result = bmw.TimeToCoverDistance(distance);
            //A 3
            Assert.Equal(2, result);
        }

        [Fact]
        public void GetDirection_DirectionBackward_Backward()
        {
            //A 1
            BMW bmw = new BMW();
            bmw.drivingMode = DrivingMode.Backward;
            //A 2
            string result = bmw.GetDirection();
            //A 3
            Assert.Equal(DrivingMode.Backward.ToString(), result);
            Assert.StartsWith("B", result);
        }


    }
}
