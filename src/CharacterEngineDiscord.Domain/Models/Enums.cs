﻿using Discord.Interactions;

namespace CharacterEngineDiscord.Domain.Models;


public enum ModalActionType
{
    CreateIntegration = 1
}


public enum ButtonActionType
{
    SearchQuery = 1,
}


public enum SinglePropertyAction
{
    show, update,

    [ChoiceDisplay("reset-default")]
    resetDefault
}

public enum MessagesFormatTarget { guild, channel, character }

public enum UserAction
{
    show, add, remove,

    [ChoiceDisplay("clear-all")]
    clearAll
}


public enum MetricUserSource
{
    SlashCommand, Button, CharacterCall
}
