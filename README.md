ColdSort
========
A music sortation application by Christopher James Allen. This is a for fun project and will be updated as long as I feel like.

Description
-----------
ColdSort allows user to automatically sort and manage your music library on your computer. It structures music files in the filesystem based on a sortation schema that the user configures. This schema reads meta-data from the music file and makes sortation decision based on it. This program can only sort mp3's as of right now but will support other popular formats later.

Example
-------
I have a song called "Test Song" by an artist called "Foo" from an album called "Bar". It is store in my music folder "C:\Users\Chris\Music\" with a few thousand other songs. I want to organize my Music folder. Using ColdSort, I configure a sortation schema to do the following: 

* It first reads the first letter of the artist's name. It creates a folder based on that first letter.
* It then creates a folder based on the artist's name.
* It then creates a folder based on the album's name.
* Finally, the song is moved from "C:\Users\Chris\Music\" to "C:\Users\Chris\Music\F\Foo\Bar\Test.mp3"

Above is how the default sortation schema works but it doesn't fully describe everything the sortation schema can do and how it can be customized.

How To Create A Sortation Schema
--------------------------------
* In the main window, under the section "Sortation Schema", click "Create".
* Enter a title for this schema.
* Choose whether you want to move unsortable (songs which fail sortation logic) into a unsortable folder or to just leave them alone. If you want to move the files to a new folder, enter a folder name in the textbox.
* Begin to construct your Sortation Nodes. Sortation Nodes, determine each individual sortation set a file will take. Click "New Node".
* Enter a name for that node.
* Select the meta-data property for the song file to be sorted against. 
* Check or uncheck whether you allow for a sortation to end at this node. This may be useful if, given the above example, you have a album-less song. If you allow sortations to end at this node then the song in the above example will be sorted to "C:\Users\Chris\Music\F\Foo\Test.mp3". If unchecked, the song would be unsortable and would sent to the unsortable folder or left alone based on your choice in the Sortation Schema options.
* Click whether you want the folder that this Sortation Node creates to do the full name of the meta-data value or just the first letter. This allows for clearer grouping. Using the above example, we see this logic where the artist is first sorted by the artist's first letter, then the artist ("F\Foo").
* Finish constructing your nodes and arranging them in the order of what sorts first.
* Run your schema.

Future Updates (In No Particular Order)
---------------------------------------
* Saving and loading of Sortation Schema in json format.
* Add diagnostic and logging information on sortation run. Allow for better tracking of files being sorted.
* Integrate progess bar into main window (get's rid of window spam).
* Multi-threading sortation support (this program is begging to be multi-threaded!)
* Better streamlined Sortation Schema creation.
* Have an option to remove empty folders (empty of music) from source directory (cleaning up after itself).
* Allow a stage-by-stage sort. Users can verify and sign off on proposed sortation paths before the files are sorted. Users can also edit the sortation path before letting sortation happen.
* Continuous bug fixes.

Contact Info
------------
Author: Christopher James Allen
Email: chris_allen@live.ca

Disclaimer!
-----------
Use this software at your own risk! I am not responsible for any thing this program may do to your system. 
