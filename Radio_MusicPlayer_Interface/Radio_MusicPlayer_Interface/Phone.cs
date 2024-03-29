﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_MusicPlayer_Interface
{
    class Phone:IMusicPlayer,IRadioplayer
    {
       public  MusicFile[] musicfiles;
       public int MusicCount { get; set; }

        public Phone()
        {
            musicfiles = new MusicFile[500];
        }

        public void Addmusicfile(params MusicFile[] musicFiles)
        {
            foreach(var M in musicFiles)
            {
                this.musicfiles[MusicCount++] = M;
            }
        }

        public void ShowList()
        {
            for(int i = 0; i < MusicCount; i ++)
            {
                musicfiles[i].Show();
            }
        }

        public void Switch(bool on)
        {
         
            if (on == true)
            {
                Console.WriteLine("Music Player is on");
            }
            else
            {
                Console.WriteLine("Music Player is Off");
            }
        }

        public void Play(bool on)
        {
            if (on == true)
            {
                Console.WriteLine("Music is playing");
            }
            else
            {
                Console.WriteLine("Music is stopped");
            }
        }

        public void Setvolume(int loudness)
        {
            if (loudness >= 7 && loudness <= 10)
            {
                Console.WriteLine("Warmning!!!!!Loud sound can damage your ears");
            }
            else if (loudness >= 1 && loudness < 7)
            {
                Console.WriteLine("Normal sound");

            }
            else if (loudness == 0)
            {
                Console.WriteLine("Muted");
            }
            else
            {

                Console.WriteLine("Volume range is 0 to 10");
            }
        }

        public void PlayNext()
        {
            Console.WriteLine("Playing next music of the list");
        }

        public void PlayPrevious()
        {
            Console.WriteLine("Playing previous  music of the list");
        }

        public void RadioSwitch(bool on)
        {
            if (on ==true)
            {
                Console.WriteLine("Radio is on");
            }
            else
            {
                Console.WriteLine("Radio is Off");
            }
        }

        public void RadioRetune(double freq)
        {
            if (freq == 100.0)
            {
                Console.WriteLine("Tuned to BBC Station");
            }
            else if (freq == 88.0)
            {
                Console.WriteLine("Tuned to  Radio Foorti Station ");
            }

            else if (freq == 90.4)
            {
                Console.WriteLine("Tuned to  Radio DhakaFm Station ");
            }

            else
            {
                Console.WriteLine(" Please select frequency 88.0/90.4/100.0");
            }
        }

        public void RadioSetvolume(int loudness)
        {
            if (loudness >= 7 && loudness <= 10)
            {
                Console.WriteLine("Warmning!!!!!Loud sound can damage your ears");
            }
            else if (loudness >= 1 && loudness < 7)
            {
                Console.WriteLine("Normal sound");

            }
            else if (loudness == 0)
            {
                Console.WriteLine("Muted");
            }
            else
            {

                Console.WriteLine("Radio Volume range is 0 to 10");
            }
        }
        public void RadioChangeChannel()
        {
            Console.WriteLine("Channel changed");
        }
    }
}
