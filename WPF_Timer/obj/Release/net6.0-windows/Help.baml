   M S B A M L   `   `   `  ???? >  :WMP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPF_Timer	WPF_Timer      WPF_Timer.Help   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:WPF_Timer       ? Title$
  HELP??$	??400??$	??500??$	??400??$	??500??$??Arial)?$??12(????	#FF1E2029 ? WindowStartupLocation$ CenterScreen=?.???  ? ColumnDefinitions ?? $??20 ??? $??* ??? $??* ??? $??* ??? $??20 ? ? RowDefinitions ?? $??20 ??? $??* ??? $??* ??? $??* ??? $
??auto ??? $??* ??? $??20 ?.+??? $??1??$??1??$??3??$
??Bold"?
????? ?$??16(?$2??,'What's My Pay?' was created by Kevin Rosas.????  ?? Orientation$ Vertical=?$??1??$??2??$??3??$??4??.+??? $??DESCRIPTION??
??? ???$
??Bold"??? 
???????$
??Wrap=?$????This program is a pay logger tool for self-employed types. This tool is useful for keeping track of the hours/minutes you've worked and dynamically finding how much you should be paid for that time using a user-inputed pay rate.???? $??
HOW TO USE??
??? ???$
??Bold"?$?? 0,5,0,0q??? 
???????$
??Wrap=?$????To start, you must input a number into 'Hourly Pay', this is your prefered pay rate. Next, click the 'CLOCK IN' button. This captures the current time (White) and adds it to your clock in time (Red). Once you have completed your task, click the 'CLOCK OUT' button to record your clock out time (green). This will automatically display the amount of time you spent on said task and calculates your total pay based on whatever you typed into the 'Hourly Pay' box. ??