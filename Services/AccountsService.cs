using System;
using AllSpice.Models;
using AllSpice.Repositories;

namespace AllSpice.Services
{
  public class AccountsService
  {

      private readonly AccountsRepository _repo;

    public AccountsService(AccountsRepository repo)
    {
      _repo = repo;
    }

    internal Account GetOrCreateAccount(Account userInfo)
    {
      Account account = _repo.GetById(userInfo.Id);
      if(account == null)
      {
          return _repo.Create(userInfo);
      }
      return account;
    }
  }
}