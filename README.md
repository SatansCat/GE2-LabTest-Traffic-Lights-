# Game Engines 2 Lab Test, Traffic Lights.

## Specification:

This is video of what you will be making in Unity for the lab test:

[![Video](http://img.youtube.com/vi/eM3jH7HW8pM/0.jpg)](http://www.youtube.com/watch?v=eM3jH7HW8pM)

You don’t have to include the soundtrack (unless of course you want to).

What is happening:

There are 10 “traffic lights” arranged in a circle of radius 10 centred around the origin (0,0,0). Each traffic light cycles through green, yellow and red and then back to green again. Traffic lights stay green for a random time of between 5 and 10 seconds. Traffic lights go yellow for exactly 4 seconds always. Traffic lights stay red for a random time of between 5 and 10 seconds and then go back to green again. When the program starts, each traffic light is set to be red, yellow or green randomly. 
The purple “car” picks a green traffic light to go to at random. It should only ever go to a green traffic light.  When it arrives at a green traffic light it should pick another green traffic light to arrive at. If the traffic light it's heading for turns yellow or red when it's on the way, it should pick a different traffic light to go to.

To get full marks, you should use steering behaviours and at least one finite state machine in your solution. Also you should generate the traffic lights procedurally. Other equally complex and flexible solutions are also acceptable. You can use any of the example code in this repository in your solution. 
