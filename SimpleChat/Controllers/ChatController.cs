﻿// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleChat.Controllers
{
	using System;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	using Microsoft.AspNetCore.Mvc;

	using SimpleChat.Models;
	using SimpleChat.Services;

	[Route("api/[controller]")]
	public sealed class ChatController: Controller
	{
		private readonly IChatService _chatService;

		public ChatController(IChatService chatService)
		{
			_chatService = chatService ?? throw new ArgumentNullException(nameof(chatService));
		}

		// DELETE api/chat/<guid>
		[HttpDelete("{id}")]
		public void Delete(Guid id)
		{
			throw new NotImplementedException();
		}

		// GET: api/chat
		[HttpGet]
		public async Task<IEnumerable<ChatMessageModel>> Get() => await _chatService.Get();

		// GET api/chat/<guid>
		[HttpGet("{id}")]
		public string Get(Guid id)
		{
			throw new NotImplementedException();
		}

		// POST api/chat
		[HttpPost]
		public async Task<ChatMessageModel> Post([FromBody] ChatNewMessageModel message) =>
			await _chatService.Send(message.Text);

		// PUT api/chat/<guid>
		[HttpPut("{id}")]
		public void Put(Guid id, [FromBody] string value)
		{
			throw new NotImplementedException();
		}
	}
}