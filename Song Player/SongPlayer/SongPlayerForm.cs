using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* TeenCoder: Windows Programming
   
   Song Player Application

   Copyright 2013 CompuScholar, Inc.
*/

namespace SongPlayer
{
    public partial class SongPlayerForm : Form
    {
        // the form data consists of a list of songs
        LinkedList<Song> songs;

        // the constructor is provided complete as part of the activity starter
        public SongPlayerForm()
        {
            InitializeComponent();

            // fill out our songs array
            initializeSongs();

        }

        // This code is ADDED FOR ACTIVITY by the student
        private void initializeSongs()
        {
            songs = new LinkedList<Song>();

            Song mario = new Song("Mario");
            mario.addNote(Note.NOTE_E, Note.DURATION_EIGHT);
            mario.addNote(Note.NOTE_E, Note.DURATION_EIGHT);
            mario.addNote(Note.NOTE_REST, Note.DURATION_EIGHT);
            mario.addNote(Note.NOTE_E, Note.DURATION_EIGHT);
            mario.addNote(Note.NOTE_REST, Note.DURATION_EIGHT);
            mario.addNote(Note.NOTE_C, Note.DURATION_EIGHT);
            mario.addNote(Note.NOTE_E, Note.DURATION_EIGHT);
            mario.addNote(Note.NOTE_REST, Note.DURATION_EIGHT);
            mario.addNote(Note.NOTE_G, Note.DURATION_QUARTER);
            mario.addNote(Note.NOTE_REST, Note.DURATION_QUARTER);
            mario.addNote(Note.NOTE_G, Note.DURATION_QUARTER);
            songs.AddLast(mario);
            SongListBox.Items.Add(mario.name);

            Song hcb = new Song("Hot Cross Buns");
            hcb.addNote(Note.NOTE_E, Note.DURATION_QUARTER);
            hcb.addNote(Note.NOTE_D, Note.DURATION_QUARTER);
            hcb.addNote(Note.NOTE_C, Note.DURATION_HALF);
            hcb.addNote(Note.NOTE_E, Note.DURATION_QUARTER);
            hcb.addNote(Note.NOTE_D, Note.DURATION_QUARTER);
            hcb.addNote(Note.NOTE_C, Note.DURATION_HALF);
            hcb.addNote(Note.NOTE_E, Note.DURATION_EIGHT);
            hcb.addNote(Note.NOTE_E, Note.DURATION_EIGHT);
            hcb.addNote(Note.NOTE_E, Note.DURATION_EIGHT);
            hcb.addNote(Note.NOTE_E, Note.DURATION_EIGHT);
            hcb.addNote(Note.NOTE_D, Note.DURATION_EIGHT);
            hcb.addNote(Note.NOTE_D, Note.DURATION_EIGHT);
            hcb.addNote(Note.NOTE_D, Note.DURATION_EIGHT);
            hcb.addNote(Note.NOTE_D, Note.DURATION_EIGHT);
            hcb.addNote(Note.NOTE_E, Note.DURATION_QUARTER);
            hcb.addNote(Note.NOTE_D, Note.DURATION_QUARTER);
            hcb.addNote(Note.NOTE_C, Note.DURATION_WHOLE);
            songs.AddLast(hcb);
            SongListBox.Items.Add(hcb.name);

            Song randomNotes = new Song("RANDOM NOTES!!!");
            randomNotes.addNote(Note.NOTE_A, Note.DURATION_HALF);
            randomNotes.addNote(Note.NOTE_B, Note.DURATION_EIGHT);
            randomNotes.addNote(Note.NOTE_G, Note.DURATION_EIGHT);
            randomNotes.addNote(Note.NOTE_E, Note.DURATION_WHOLE);
            randomNotes.addNote(Note.NOTE_A, Note.DURATION_EIGHT);
            randomNotes.addNote(Note.NOTE_B, Note.DURATION_HALF);
            randomNotes.addNote(Note.NOTE_C, Note.DURATION_WHOLE);
            randomNotes.addNote(Note.NOTE_A, Note.DURATION_EIGHT);
            randomNotes.addNote(Note.NOTE_A, Note.DURATION_EIGHT);
            randomNotes.addNote(Note.NOTE_D, Note.DURATION_QUARTER);
            songs.AddLast(randomNotes);
            SongListBox.Items.Add(randomNotes.name);
        }

        // This function is provided as part of the activity starter.
        private void PlayButton_Click(object sender, EventArgs e)
        {
            // get the current selection index
            int selection = SongListBox.SelectedIndex;
            if (selection >= 0)
            {
                // get the selected song from the list
                Song s = songs.ElementAt(selection);

                // play the song
                s.play();
            }

        }
    }
}
