# Carrot or Stick experiment
code used for HRI2020 late breaking article

# License #
If you use this system in any way, please include a reference to the following paper:

Mirjam de Haas and Rianne Conijn. 2020. Carrot or Stick: The Effect of Reward and Punishment in Robot Assisted Language Learning. In Companion of the 2020 ACM/IEEE International Conference on Human-Robot Interaction (HRI '20). Association for Computing Machinery, New York, NY, USA, 177–179. DOI:https://doi.org/10.1145/3371382.3378349

bibtex:
@inproceedings{10.1145/3371382.3378349,
author = {de Haas, Mirjam and Conijn, Rianne},
title = {Carrot or Stick: The Effect of Reward and Punishment in Robot Assisted Language Learning},
year = {2020},
isbn = {9781450370578},
publisher = {Association for Computing Machinery},
address = {New York, NY, USA},
url = {https://doi.org/10.1145/3371382.3378349},
doi = {10.1145/3371382.3378349},
booktitle = {Companion of the 2020 ACM/IEEE International Conference on Human-Robot Interaction},
pages = {177–179},
numpages = {3},
keywords = {foreign language learning, robot tutoring, feedback},
location = {Cambridge, United Kingdom},
series = {HRI '20}
}

# Instructions #
Note: The system only runs with actual NAO robots, unfortunately due to our use of qimessaging the Choregraphe simulator does not work. There also appears to be a problem with newer versions of the NAOqi software (on the robot), where qimessaging has been removed.

First, the Choregraphe projects in the choregraphe_projects directory need to be installed on the NAO robot. Second, you also need the connectionmanager module from the main l2tor github (github/l2tor).

To run the system, use the following commands: python connectionManager/tablet/server.py --robotIP [robotip] --computerIP [ip_sys]

start.py -i [robotip] -s [ip_sys] -c [condition] -v [word_set]

Replace [robotip] with the ip address of your NAO robot on the network, [ip_sys] with the ip of your computer, [word_set] should be 1,2 or 3 and [condition] should be one of the following: 1 - no feedback 2 - dispreferred feedback 3 - preferred feedback

Finally, you can open WoZControl.exe to start the experiment. If you want to run this control panel from a different machine than the companion tablet game and other modules, make sure to include robotip.js (in the root directory) so that it knows where to connect to and change the IP address in the control panel to the ip address of the tablet, default is 127.0.0.1. Make sure you add a semicolon in between the child's name, participant number and robot-name. To start the experiment, click on Connect, Sync (you will hear a sound) and on Start Lesson.

Note that this control panel has more options than are currently implemented in this experiment.

# Project structure #
Directory	Description
animalexperimentservice	Output management (speech and gesture production)
interactionmanager	Interaction management (tracks progress through the experiment, decides what to do next)
controlpanel	Interface used to start the experiment

# Making changes #
In order to add your own concepts, the following steps are needed:

Update CSV files in interactionmanager/data/study_1/
If needed: add gestures of the concepts to choregraphe_projects/
Update the concepts at the top of the animalexperimentservice/app/scripts/myservice.py file
Note: to keep the voice between languages consistent, we used phonetic second language pronunciations in the first language instead of a different voice.
