# IC-Market
You are about to implement a Command and Control application (C2C).

A C2C application is communicating with 1 to N devices "out there" - a rocket launcher, interceptor, naval radar. Each of these has its own protocol and a communication channel (TCP/IP, Serial Port, HTTP, RF, etc.).

Your C2C is connected to a single device only – a camera. Bear in mind that at the end of the day your application should allow the end-user to use this camera, sending commands and controlling it (for example, zooming in or out).

So… please design and implement a small C2C application, using C# code (any .NET framework you choose is accepted), and pay attention to the following leads:

    • A software object should represent your camera (quite obvious).

    • Your camera is also a device, so please think about any Object-Oriented concept to let it enjoy being a device. Think of common functionality to devices in general.

    • Camera should be replaceable. Meaning, next year a better model hits the market, and you C2C application would like to use it. Think of a way to make this change as painless as possible (hopefully no code changes at all in your application).

    • Ignore the actual communication channel and protocol at the moment. Assume you have a reference to IComm interface, and a reference to CameraCommChannel object (implements the IComm). Use it whenever you think this is needed. Hint: you need it in every operation communicating with the camera.

    • Please also write some unit testing methods, in a dedicated unit testing project. If you wanna use any mocking framework please feel free doing so.

    • Wrap it all in a simple console application, and demonstrate how you can actually use the camera. You can create a basic UI if you feel like (Windows Forms, WPF, Web Application) but this is completely unnecessary.


There is no right or wrong here. We are checking mostly the approach and your coding skills. Focus on basic Object-Oriented principles, neat and tidy code, naming conventions, error handling, etc. Please send us the solution with all code included (compiled and running), and feel free to attach also a summary of your work (concept, UML diagram(s), design, thoughts, things still under TBD, etc.).

