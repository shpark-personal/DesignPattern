public class Facade{
    public  static void Run(){
        HomteTheaterFacade homeTheater = new HomteTheaterFacade(
            new Amplifier(), 
            new Tuner(), 
            new StreamingPlayer(),
            new Projector(),
            new Screen(),
            new TheaterLights(),
            new PopcornPopper());
        homeTheater.watchMovie("μλΌλ");
        homeTheater.endMovie();
    }
}