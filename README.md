# OPIRL
Welcome to One Piece In Real Life! OPIRL is a project in order to bring the One Piece devil fruit power system to life, so anyone can enjoy stretching their arms with the Gomu Gomu No Mi or creating earthquakes with the Gura Gura No Mi in AR! 

OPIRL is built using Unity3D for HoloLens2. Since HoloLens2 is Microsoft based, **only Windows currently supported**.
OPIRL uses MRTK 2.8.0.0 and FMOD 2.02.07.

How to install OPIRL onto HoloLens:
* Step 1: Download latest build of OPIRL onto a Windows computer/laptop **and** Visual Studio
* Step 2: Physically connect your Hololens2 using USB-C port
* Step 3: Extract build (if zipped) and open OPIRL.sln
* Step 4: Change build type to "Master"
* Step 5: Change architecture to "ARM" 
* Step 6: Change build destination to "Device" 

After Steps 4-6, the top bar of your OPIRL.sln should look like this:
![image](https://user-images.githubusercontent.com/30392769/174676195-dd321194-96a3-4078-a67c-c94574a318ff.png)

* Step 7: Hit the green play button with no color fill (directly right of "Device")
* Step 8: Once the download finishes, go to "All Apps" and search for OPIRL
* Step 9: Enjoy :)


Changelog:

v0.0.3 
* Modified MRTK2 Profile in order to hide boundaries (bugged)
* Added small spheres for joint tracking based on MRTK2
 
v0.0.2 (Unreleased)
* Added directional sound with FMOD and custom sound player
* Added 2 base songs (From One Piece's Wano track list)

v0.0.1 (Unreleased)
* Created Base MRTK2 Project Template
* Created basic menu (no scroll) 
