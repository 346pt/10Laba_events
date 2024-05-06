Event event1 = new Event { Name = "события 1"};
Event event2 = new Event { Name = "события 2"};
EventText event3 = new EventText ();

event1.EventCreator += event3.EventProcessing;
event2.EventCreator += event3.EventProcessing;

event1.EventGenerator();
event2.EventGenerator();

Console.ReadKey();