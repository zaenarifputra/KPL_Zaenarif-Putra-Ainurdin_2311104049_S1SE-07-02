using System;

public class Program
{
    public enum GameState
    {
        Menu,
        Bermain,
        GameOver
    }

    private GameState currentState;

    public Program()
    {
        currentState = GameState.Menu;
    }

    public void ChangeState(GameState newState)
    {
        currentState = newState;
        Console.WriteLine($"Berpindah ke state: {currentState}");
    }

    public void Run()
    {
        while (true)
        {
            switch (currentState)
            {
                case GameState.Menu:
                    Console.WriteLine("Di Menu Utama. Pilih 'start' untuk mulai bermain");
                    Console.WriteLine("Tekan 'S' untuk start atau 'Q' untuk keluar");
                    var menuChoice = Console.ReadKey(true).Key;
                    if (menuChoice == ConsoleKey.S)
                    {
                        ChangeState(GameState.Bermain);
                    }
                    else if (menuChoice == ConsoleKey.Q)
                    {
                        return;
                    }
                    break;

                case GameState.Bermain:
                    Console.WriteLine("Bermain... Tekan 'G' untuk Game Over atau 'Q' untuk keluar.");
                    var gameChoice = Console.ReadKey(true).Key;
                    if (gameChoice == ConsoleKey.G)
                    {
                        ChangeState(GameState.GameOver);
                    }
                    else if (gameChoice == ConsoleKey.Q)
                    {
                        return;
                    }
                    break;

                case GameState.GameOver:
                    Console.WriteLine("Game Over! Tekan 'R' untuk kembali ke Menu atau 'Q' untuk keluar.");
                    var gameOverChoice = Console.ReadKey(true).Key;
                    if (gameOverChoice == ConsoleKey.R)
                    {
                        ChangeState(GameState.Menu);
                    }
                    else if (gameOverChoice == ConsoleKey.Q)
                    {
                        return;
                    }
                    break;
            }
        }
    }

    public static void Main()
    {
        Program game = new Program();
        game.Run();
    }
}