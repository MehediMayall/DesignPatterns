using ObserverPattern;



var alarm = new Alarm();

alarm.AddWatcher(new PoliceStation());
alarm.AddWatcher(new FireStation());
alarm.AddWatcher(new HospitalStation());


alarm.Notify();
