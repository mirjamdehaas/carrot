import subprocess
import shlex
import os

import signal
import sys
import getopt
import time

import webbrowser

# Conditions:
# 1 = no feedback
# 2 = worst feedback
# 3 = best feedback


def main(argv):
    strategy = 'best'
    
    ip = '169.254.197.247'
    ip_sys = "137.56.54.212"
    condition = 0
    gestures = 0
    verbalization = ""
    retention = ""
    intro = False
    print argv
    try:
        opts, args = getopt.getopt(argv, "hi:c:v:r:", ["ip=", "condition=", "verbalization=", "retention="])
    except getopt.GetoptError:
        print 'start.py -i <robot_ip> -c <condition> -v <1/0>'
        sys.exit(2)
    for opt, arg in opts:
        if opt == '-h':
            print 'start.py -i <robot_ip> -c <condition> -v <true/false>'
            sys.exit()
        elif opt in ("-i", "--ip"):
            ip = arg
        elif opt in ("-c", "--condition"):
            try:
                if int(arg) > 10 and int(arg) < 34:
                    condition = int(arg)
            except ValueError:
                pass
        elif opt in ("-v", "--verbalization"):
            verbalization = arg
        elif opt in ("-r", "--retention"):
            retention = arg

    if condition == 0:
        print 'start.py -i <robot_ip> -c <condition>'
        sys.exit(2)

    print("condition:",condition)
    if condition == 11:
        strategy = "no"
        woordenset = 1      

    elif condition == 21:
        strategy ="punishment"
        woordenset = 1  

    elif condition == 31:
        strategy = "reward"       
        woordenset = 1

    # Write robot IP to file
    f = open('robotip.js', 'w')
    f.write('ROBOT_IP = "' + ip + '";')
    f.close()

    # No need to change directory for our service as it doesn't need file system
    p1 = subprocess.Popen(shlex.split("python \"animalexperimentservice/app/scripts/myservice.py\" --qi-url " + ip + " --verbalization " + str(woordenset) + " --strategy " + strategy))

    # Interaction manager, however, does!
    os.chdir('interactionmanager/src')
    #p2 = subprocess.Popen(shlex.split("python interaction_manager.py --ip " + ip + " --port 9559 --sysip "+ip_sys+" --mode \"" + strategy + "\" --sgroups \"type\" --L1 \"English\" --L2 \"English\" --concepts \"../data/study_1/animals_concepts.csv\" --cbindings \"../data/study_1/animals_concept_bindings.csv\" --rnr=1 --chunks=9 --gestures=" + str(woordenset)))
    p2 = subprocess.Popen(shlex.split("python interaction_manager.py --ip 127.0.0.1 --port 54326 --sysip 192.168.2.6 --mode \"" + strategy + "\" --sgroups \"type\" --L1 \"German\" --L2 \"English\" --concepts \"../data/study_1/animals_concepts.csv\" --cbindings \"../data/study_1/animals_concept_bindings.csv\" --rnr=1 --chunks=6 --gestures=" + str(gestures)))

    time.sleep(2)

    dir_path = os.path.dirname(os.path.realpath(__file__))
    webbrowser.get('C:/Program Files (x86)/Google/Chrome/Application/chrome.exe %s').open('file://' + dir_path + '/web_2/index.html')

    def signal_handler(signal, frame):
        print('Ctrl+C detected, stopping the services..')
        p1.kill()
        p2.kill()
        time.sleep(1)
        sys.exit(0)

    signal.signal(signal.SIGINT, signal_handler)
    print('Press Ctrl+C to stop experiment')

    loop = True

    while loop:
        time.sleep(1)
        loop = p1.poll() == None or p2.poll() == None


if __name__ == "__main__":
    main(sys.argv[1:])
