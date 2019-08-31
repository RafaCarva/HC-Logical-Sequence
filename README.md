# HC-Logical-Sequence
Um jogo para ensinar sequenciamento lógico

Versão do Unity utilizada:
2018.3.14f1

## Como funciona
###Gerenciador
O gerenciador da fase é o empytGame "MySceneManager" que contém um script com o mesmo nome. Quando a fase inicia, o método awake() esconde o UI de encerramento. Esse script possui algumas variaveis públicas que precisam ser setadas via engine.</br>
</br>
###Player
O Game Object player inicia com "isKnematic = true" assim a bolinha fica parada no ar e só vai sofrer a ação da gravidade quando o jogador apertar o botão play.</br>
</br>
###UI
O Game Object UICanvas abriga toda a UI, como inicialmente a tela de encerramento foi escondida, tudo que o jogador vê é a tela de lógica onde ele pode arrastar e soltar as setas para gerar a sequência.</br>
</br>
###Zones
O Game Object win zone possui apenas um colider que vai iniciar a "montagem da tela de encerramento". Basicamente ele seta como "falso" o deslocamento da bolinha e chama o método stageUIBuilder do gerenciador mySceneManager. Enquanto o player está em contato com o win zone, acontece a animação da bolinha através de um "AddForce".</br>
O Game Object Dead zone possui um colider também, a diferença entre ele e o win zone é que ele vai setar a variável bool de mySceneManager "isPlayerWin" para false, enquanto win zone o seta para true. A montagem da UI leva em consideração essa bool para compor as frases.</br>
 </br>
###Database
Um banco de dados MySql foi criado no serviço www.000webhost.com. Os dados para acesso estão na tarefa no trello. O Game Object Panel-Database utiliza o script Database.cs para chamar o script php que está hospedado nesse mesmo servidor. </br>
</br>
###Assets
Utilizei assets free para compor as cenas. Na pasta assets está o arquivo de adobe illustrator com algumas ilustrções 2D utilizadas.</br>
Vários assets possuem um scrip próprio para setar alguma animação como por exemplo a nuvem  e a chave.
</br>
###Melhorias
O objetivo do projeto é a validação do MVP do jogo, praticamente todos os aspectos poderiam ser melhorados se o projeto fosse ser desenvolvido como por exemplo:</br>
* Melhorias no sistema de drag and drop e de como gerar os slots dinamicamente na montagem de uma fase.</br>
* Utilização mais aprofundada na física para a utilização de "mecânicas" mais interessantes como loops (como os do sonic), elevadores, teletransportadores etc.</br>
* Criação de uma identidade visual (2D e 3D) para jogo.</br>
* Utilização de um banco de dados em um serviço mais estável (AWS, Azure etc).</br>