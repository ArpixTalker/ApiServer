   M S B A M L   `   `   `  ����K  GModule.ApiServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Modules.ApiServer.ViewsModules.ApiServer.Views  5      ,    &Modules.ApiServer.Views.ServerMainView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:Modules.ApiServer.Views     5      T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5	      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5
       � 	Resources 5         UpdateButtonStyle �� 
TargetType �� Property �� Value�� 5   
   %  &	        �� 5      " ��6.   .�5      ��  � ��
 �����6/   �� 5       � ��
 ��  �6/   �� 5       � ��
 ��  �60   �� 5       � ��$
 Bold"�6/   �� 5       � ��$ 14(�6-   �� 5       � ��$ 25��6+   5      5      .��5   
   �  � ColumnDefinitions 5   
    � RowDefinitions 5"   
   �� 5#      $��10 �6   �� 5$      $��* �6   �� 5%      $��10 �6   �� 5&      $��25 �6   .+�5)   
   �� $��1��5*      �� 5,   
   $��3��5-      #��[  5.      ��5/      �� *ToggleButtonText+��50      �� *ToggleServerCommand+53      54      