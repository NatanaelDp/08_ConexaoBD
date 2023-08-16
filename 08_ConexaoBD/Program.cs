
using _08_ConexaoBD;


//ConexaoSimples conexaoSimples= new ConexaoSimples();
ConexaoFlexivel conexaoFlexivel=new ConexaoFlexivel();
conexaoFlexivel.executaQuery("SELECT*FROM tarefas;");
conexaoFlexivel.executaQuery("SELECT*FROM tarefas WHERE id=4;");
conexaoFlexivel.executaQuery("SELECT*FROM tarefas WHERE descricao LIKE '%tud%';");
conexaoFlexivel.executaQuery("SELECT")




Console.ReadLine();
