   M S B A M L   `   `   `  ����Y  UJulMar.Wpf.Helpers, Version=4.0.0.4, Culture=neutral, PublicKeyToken=3ea22013129d8c94_Bclr-namespace:JulMar.Windows.Behaviors;assembly=JulMar.Wpf.HelpersJulMar.Windows.Behaviors  5   	    WebSearcher"   WebSearcher.Views.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   UjulmarBclr-namespace:JulMar.Windows.Behaviors;assembly=JulMar.Wpf.Helpers     5   	     � Title$  Web Search - C# 5.0 Lab��5   	   $	��536��5   	   $	��586��6    � Icon$$ /WebSearcher;component/App.ico��5   	   $��14(�6/   .��5      �  � RowDefinitions 5	   
   �� 5
      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   � -   5        $��grid1��5       � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   �� 5      $
��Auto �6#   .+�5      �� $��Enter search term:��6   $��10q�62   �� 5      $��1��6   $��10q�6&   ��62   ��  �� Path$ 
SearchText� �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=��� 5      $��
Run Search��6   $��2��6*   $��10q�6:   ��6F   �� *SearchCommand+5      �� 5   
   $��2��6   $��10q�6<   ��6!   �� *	StatsText+6<   �� 5   
   $��1��6    �� SelectedItem 6   �� *SelectedResult+��6G   �� *SearchResults+-   'JulMar.Windows.Behaviors.EventCommander   Mappings 5      +   %JulMar.Windows.Behaviors.CommandEvent  	   Event$	 MouseDoubleClick��6&   
   Command
 6?   �� *VisitSelectedSiteCommand+5      5      5      