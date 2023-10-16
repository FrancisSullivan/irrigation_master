
Currently in the early prototype phase.
This is an app designed to control an irrigation system on a farm.

<img width="714" alt="Screenshot 2023-09-07 at 8 44 07 am" src="https://github.com/FrancisSullivan/irrigation_master/assets/99381522/2c71873d-e800-4d7d-b348-3049ee11431f">


The user can select. 
-	which section is to be watered.
-	the time at which the watering of that section will start.
-	the duration of the watering period for that section.

The program will automatically calculate the times for which taps are turned, and when pumps are started.

More complex features.
-	Multiple sections may be watered at once.
-	One or both pumps may be running at the same time.

The backend logic behind the turning of taps is considerably more complex than the logic driving the front end, the front end has been simplified presenting the user with only the most necessary inputs to define the process flow.

The app also allows for swapping of items.
-	The duration is maintained while the order is changed.
