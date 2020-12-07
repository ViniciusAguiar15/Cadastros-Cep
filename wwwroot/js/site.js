/**
    * Validação de CEP e busca no webservice da PostMon.
    */

//Quando o campo cep perde o foco.
$("#consultarCEP").click(function () {

    //Nova variável "cep" somente com dígitos.
    var cep = $("#CEP").val().replace(/\D/g, '');

    //Verifica se campo cep possui valor informado.
    if (cep == "") {
        alert("Por favor, informe o CEP.");
        limparEndereco();
        return;
    }

    //Expressão regular para validar o CEP.
    var validacep = /^[0-9]{8}$/;

    //Valida o formato do CEP.
    if (!validacep.test(cep)) {
        //cep é inválido.
        limparEndereco();
        alert("Formato de CEP inválido.");
    }

    //Preenche os campos enquanto consulta o webservice.
    $("#Logradouro").val("Buscando dados, aguarde...");
    $("#Bairro").val("Buscando dados, aguarde...");
    $("#Cidade").val("Buscando dados, aguarde...");

    //Consulta o webservice viacep.com.br/
    $.getJSON(`https://api.postmon.com.br/v1/cep/${cep}?format=json`, function (dados) {

        //Atualiza os campos com os valores da consulta.
        $("#Logradouro").val(dados.logradouro);
        $("#Complemento").val(dados.complemento);
        $("#Bairro").val(dados.bairro);
        $("#Cidade").val(dados.cidade);
        $("#Estado").val(dados.estado);
    }).fail(function () {
        limparEndereco();
        alert("CEP não encontrado.");
    })
});
