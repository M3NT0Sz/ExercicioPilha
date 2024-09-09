//Ex1
Documento documento = new Documento();
documento.push("documento1", "txt", 10);
documento.push("documento2", "js", 40);
documento.push("documento3", "php", 40);

documento.pop();
documento.imprimir();

documento.consulta("documento1");
documento.consulta("documento5");