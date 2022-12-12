﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiscordBot.DataAccess.Contract.TwitterRegistration.Domain;

public interface ITwitterRegistrationDomain
{
    Task<bool> IsAccountRegisteredOnChannelAsync(ulong guildId, ulong channelId, string username);
    Task RegisterTwitterAsync(TwitterRegistrationDto twitterRegistrationDto);
    Task<IReadOnlyCollection<TwitterRegistrationDto>> RetrieveAllRegistartionsAsync();
    Task UnregisterTwitterAsync(ulong guildId, ulong channelId, string username);
    Task<IReadOnlyCollection<TwitterRegistrationDto>> RetrieveAllRegistartionsForGuildAsync(ulong guildId);
}