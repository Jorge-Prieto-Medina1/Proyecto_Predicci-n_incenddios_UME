   M S B A M L   `   `   `  ����Z  VProyectoIncediosUME_JorgePrieto, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:ProyectoIncediosUME_JorgePrieto.Clases&ProyectoIncediosUME_JorgePrieto.Clases  5   	   J    DProyectoIncediosUME_JorgePrieto.VentanaConsultarProbabilidadIncendio   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Gclases4clr-namespace:ProyectoIncediosUME_JorgePrieto.Clases     5   	   -   5          � Title$$  Ventana Consultar Probabilidad��5   	   $��399.273��60   $	��800��6A    � WindowStartupLocation$ CenterScreen=�6M    � 
ResizeMode$ NoResize=�6r   ���#499BEE � WindowStyle$
 None=�6�    J� CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5           Command$! clases:Comandos.volverAtras��5
      6V     5   
   -   5        $* $clases:Comandos.calcularProbabilidad��5      6_   .��5      � .+�5   
   �� -   5         ��Name$ btnVolverAtras��5   (   $��Volver atras��6   $
��Left=�6@   $��41��6[   $��
639,35,0,0q�6g   $	��Top=�6{   $	��151��6�   ���	#FF3679CD$��18(�6�   $��Lucida Sans Unicode)�6�   $!��clases:Comandos.volverAtras��6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      � 	 � Color$	 	#FFEEDF49��6#   
 � Offset$
 0Q�65   � 5      $	 White��6#   $
 1Q�61   5      5      �� 5   
   $
��Left=�6   $��40��6/   $��	58,35,0,0q�6;   $
��Wrap=�6N   $	��Top=�6b   $	��562��6z   $��28(�6�   ���#EE4958$��Lucida Sans Unicode)�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.025Q�6&   T� 5      5      �� 5   *   $!�Consultar probabilidades de��6.   �� 6S   $� ��6W   �� 6b   $�un incendio��6f   6|   �� 5   
   -   5         ��Name$ cmbProvincias��5      $
��Left=�6*   $��29��6E   $��176,145,0,0q�6Q   $	��Top=�6f   $	��160��6~   $��18(�6�   6�   �� 5    
   $
��Left=�6   $��30��6/   $��
47,214,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��100��6{   $��20(�6�   ���#EE4958$��Lucida Sans Unicode)�6�   $ 0.505,-0.167&�6�   �� 6�   $�L��6�   �� 6  $�	ocalidad:��6  6  �� 5!   
   -   5        $ cmbLocalidades��5!      $
��Left=�6+   $��29��6F   $��176,214,0,0q�6R   $	��Top=�6g   $	��160��6   $��18(�6�   �� 5"   
   $
��Left=�6   $��30��6/   $��
57,145,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $��90��6{   $��18(�6�   ���#EE4958$��Lucida Sans Unicode)�6�   $ 0.505,-0.167&�6�   �� 6�   $�Provinci��6�   �� 6  $�a:��6  6  �� 5#   
   $
��Left=�6   $��30��6/   $��505,176,0,0q�6;   $
��Wrap=�6P   $	��Top=�6d   $	��189��6|   $��20(�6�   ���#EE4958$��Lucida Sans Unicode)�6�   $ 0.505,-0.167&�6�   $��Riesgo de incendio��6�   (  "System.Windows.Controls.DatePicker  5$   
   -   5          Name$ dpkFecha��5$      |�.  $
��Left=�6;   $��176,278,0,0q�6V   $	��Top=�6k   $	��186��6�   $��16(�6�   $��29��6�   $ 
0.55,0.567&�6�   �� 5%   
   $
��Left=�6   $��30��6/   $��
85,278,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $��62��6{   $��20(�6�   ���#EE4958$��Lucida Sans Unicode)�6�   $ 0.505,-0.167&�6�   $��Fecha:��6�   �� 5&   
   -   5        $ btnCalcularRiesgo��5&   7   $!��Calcular riesgo de incendio��6   $
��Left=�6R   $��41��6m   $��277,333,0,0q�6y   $	��Top=�6�   $	��264��6�   ���	#FF3679CD$��18(�6�   $��Lucida Sans Unicode)�6�   $*��$clases:Comandos.calcularProbabilidad��6�   ��5'      �� 5(      $ 0.5,1&�6&   $ 0.5,0&�67   .��5)      � $	 	#FFEEDF49��6#   $
 0Q�65   � 5*      $	 White��6#   $
 1Q�61   5+      5-      �� 5.   
   -	   5         ��Name$ 	txtRiesgo��5.       �� 
IsReadOnly . $
��Left=�67   $��30��6R   $��505,214,0,0q�6^    �� TextWrapping$
 Wrap=�6s   $	��Top=�6�   $	��189��6�   $��18(�6�   5/      50      