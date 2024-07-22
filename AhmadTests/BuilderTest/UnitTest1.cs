using Builder;

namespace BuilderTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Client create a director obhect and configures it with the describe 
            //Builder object 

            var mazeGame = new MazeDirector(new StandardMaze());
            mazeGame.HardMAze();
        
            mazeGame.Build();
        }
    }
}