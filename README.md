# KAFKA TEST MESSAGER

This app has three parts: 
    1. kafka cluster image (docker-compose.yml), 
    2. Producer (Sender File - c# console app)
    3. Receiver (Receiver File - c# console app)

## Required software for this project
    1. must have Visual Studio installed.
    2. must have Docker installed
    
## Running this project
    1. Navigate to the root of this project (where the docker-compose file exists)
    2. In a powershell/git bash terminal type the command: "docker compose up"
    3. Once the instance of the kafka cluster and zookeeper are running (to see the container's running type command: "docker container list" or view these instances in docker desktop.) open the sender project in Visual Studio and run.
        a. wait until the kafka cluster recognises the producer running, can take a few seconds and will show in the terminal that is running the docker-compose
    4. Open the Receiver project in Visual Studio and run.  
        a. just like the producer, wait a few seconds for it to recognize and this will also show in the terminal running docker-compose
    5. In the command window for your producer you will see the ability to add a message. Once a message is entered and you click enter you will see the message in the consumer command window.
