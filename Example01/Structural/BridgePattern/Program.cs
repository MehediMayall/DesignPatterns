/*
Bridge Pattern

Bridge pattern decouples an abstraction from its implementation so that two can vary independently.

Bridge Pattern is a structural design pattern that lets you split a large class or a set of closely 
related classes into two separated hierarchies - abstraction and implementation - which can be 
developed independently of each other.
*/

using BridgePattern;

IMessageService messageService = new MessageService(MessageTypes.EMAIL);

messageService.SendMessage("mehedi.sun@gmail.com", "This is an test email");

messageService.SendMessage(MessageTypes.SMS, "01913-562933", "This message is being sent via SMS");




