# Rotation
Prototype of mouse rotation config interface

### Development
I chose wpf for prototyping because it has features like transformations. Especially the rotation transformation will make our lives easier.

So we have one main view, which is located in `View.xaml`, and a view model for it, located in `ViewModel.cs`. I've also created a separate control for the circle with an arrow that shows the angle. It's located in `controls/AngleView.xaml`.

At first, I made a slider that starts at 0 and ends at 360. But during the development process, I realized that it would be more convenient to use a slider that ranges from -180 to 180. If we move the slider to the right, the arrow also moves to the right. And if we move it to the left, the arrow moves to the left.

There is a little video in file screencast.mkv