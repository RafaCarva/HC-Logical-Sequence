# HC-Logical-Sequence
Um jogo para ensinar sequenciamento lógico</br>
![01](https://user-images.githubusercontent.com/13722768/65601868-50bb4d80-df79-11e9-9ee3-f94c9b98c31c.jpg)
![02](https://user-images.githubusercontent.com/13722768/65601873-53b63e00-df79-11e9-81e0-eefad5eefb8a.jpg)
![03](https://user-images.githubusercontent.com/13722768/65601874-544ed480-df79-11e9-8389-15997189c8e3.jpg)
</br>
Versão do Unity utilizada:
2018.3.14f1

## Como funciona
### Gerenciador
O gerenciador da fase é o empytGame "MySceneManager" que contém um script com o mesmo nome. Quando a fase inicia, o método awake() esconde o UI de encerramento. Esse script possui algumas variaveis públicas que precisam ser setadas via engine.</br>
</br>
### Player
O Game Object player inicia com "isKnematic = true" assim a bolinha fica parada no ar e só vai sofrer a ação da gravidade quando o jogador apertar o botão play.</br>
</br>
### UI
O Game Object UICanvas abriga toda a UI, como inicialmente a tela de encerramento foi escondida, tudo que o jogador vê é a tela de lógica onde ele pode arrastar e soltar as setas para gerar a sequência.</br>
</br>
### Zones
O Game Object win zone possui apenas um colider que vai iniciar a "montagem da tela de encerramento". Basicamente ele seta como "falso" o deslocamento da bolinha e chama o método stageUIBuilder do gerenciador mySceneManager. Enquanto o player está em contato com o win zone, acontece a animação da bolinha através de um "AddForce".</br>
O Game Object Dead zone possui um colider também, a diferença entre ele e o win zone é que ele vai setar a variável bool de mySceneManager "isPlayerWin" para false, enquanto win zone o seta para true. A montagem da UI leva em consideração essa bool para compor as frases.</br>
 </br>
### Database
Um banco de dados MySql foi criado no serviço www.000webhost.com. Os dados para acesso estão na tarefa no trello. O Game Object Panel-Database utiliza o script Database.cs para chamar o script php que está hospedado nesse mesmo servidor. </br>
</br>
### Assets
Utilizei assets free para compor as cenas. Na pasta assets está o arquivo de adobe illustrator com algumas ilustrções 2D utilizadas.</br>
Vários assets possuem um scrip próprio para setar alguma animação como por exemplo a nuvem  e a chave.
