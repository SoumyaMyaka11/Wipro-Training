using System;

namespace Linq_Project
{
     interface IMusicPlayer
    {
        void Play();
        void Pause();
        void Stop();
    }

    class SpotifyPlayer : IMusicPlayer
    {
        public void Play()
        {
            Console.WriteLine("playing song on spotify");
        }
        public void Pause()
        {
            Console.WriteLine("spotify playback paused");

        }
        public void Stop()
        {
            Console.WriteLine("spotify playback stopped");
        }
    }

    class AppleMusicPlayer : IMusicPlayer
    {
        public void Play()
        {
            Console.WriteLine("playing song on apple music");
        }
        public void Pause()
        {
            Console.WriteLine("apple music playback paused");

        }
        public void Stop()
        {
            Console.WriteLine("apple music playback stopped");
        }
    }

    class Program
    {
        public static void Main()
        {
            IMusicPlayer music;

            music = new SpotifyPlayer();
            music.Play();
            music.Pause();
            music.Stop();

            music = new AppleMusicPlayer();
            music.Play();
            music.Pause();
            music.Stop();
        }
    }
}
