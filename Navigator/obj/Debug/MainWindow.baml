   M S B A M L   `   `   `  ????D  @Navigator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Navigator	Navigator  5   	       Navigator.MainWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Navigator     5   	     ? Title$  	Navigator??5	   	   $	??650??6   $	??800??6(    ? 
ResizeMode$ NoResize=?64    ? Icon$ navigator.png??6J    ? WindowStyle$
 None=?6_   .??5      ? -   5         ?Name$ MainRoot??5      ???#E1FCF6 ? ColumnDefinitions 5   
   ?? 5      $
??202* ?6   ?? 5      $
??591* ?6   .+?5   
   ? -   5        $ TopRoot??5      $
??Left=?6    $??62??6;   $	??Top=?6G   $	??800??6_   ???#E1FCF6$??2??6?   $??
0,0,-6.4,0q?6?   .+?5      ?? -   5         ??Name$ 
car_button??5      $?? ??6)   $
??Left=?64   $??	10,10,0,0q?6O   $	??Top=?6b   $??42??6z   $??42??6?   ???#24AA8F???#24AA8F6?   ?? 5      -   5        $ bicycle_button??5      $?? ??6-   $
??Left=?68   $??	70,10,0,0q?6S   $	??Top=?6f   $??42??6~   $??42??6?   ???#24AA8F???#24AA8F6?   ?? 5      -   5        $ train_button??5      $?? ??6+   $
??Left=?66   $??
130,10,0,0q?6Q   $	??Top=?6e   $??42??6}   $??42??6?   ???#24AA8F???#24AA8F6?   ?? 5      -   5        $ walker_button??5      $?? ??6,   $
??Left=?67   $??
190,10,0,0q?6R   $	??Top=?6f   $??42??6~   $??42??6?   ???#24AA8F???#24AA8F6?   ?? 5      -   5        $ clear_button??5      $??Clear Roads??6+   $??Right=?6A   $??	0,10,10,0q?6]   $	??Top=?6p   $	??110??6?   $??42??6?   ???#24AA8F???#24AA8F6?   5      ? 5   
   $
??Left=?6   $	??568??6*   $??	10,72,0,0q?67   $	??Top=?6J   $	??780??6b   $??2??6n   ???#EAFEFA J? Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q?6#   	   ShadowDepth$	 10Q?64   
   Opacity$	
 0.4Q?6E      	Direction$	 270Q?6S   5      5      5       