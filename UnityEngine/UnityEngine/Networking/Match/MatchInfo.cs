﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Networking.Match.MatchInfo
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A8FF7A2C-E4EE-4232-AB17-3FCABEC16496
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEngine.dll

using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
  /// <summary>
  ///   <para>Details about a UNET Matchmaker match.</para>
  /// </summary>
  public class MatchInfo
  {
    /// <summary>
    ///   <para>IP address of the host of the match,.</para>
    /// </summary>
    public string address { get; private set; }

    /// <summary>
    ///   <para>Port of the host of the match.</para>
    /// </summary>
    public int port { get; private set; }

    /// <summary>
    ///   <para>The unique ID of this match.</para>
    /// </summary>
    public NetworkID networkId { get; private set; }

    /// <summary>
    ///   <para>The binary access token this client uses to authenticate its session for future commands.</para>
    /// </summary>
    public NetworkAccessToken accessToken { get; private set; }

    /// <summary>
    ///   <para>NodeID for this member client in the match.</para>
    /// </summary>
    public NodeID nodeId { get; private set; }

    /// <summary>
    ///   <para>Flag to say if the math uses a relay server.</para>
    /// </summary>
    public bool usingRelay { get; private set; }

    public MatchInfo(CreateMatchResponse matchResponse)
    {
      this.address = matchResponse.address;
      this.port = matchResponse.port;
      this.networkId = matchResponse.networkId;
      this.accessToken = new NetworkAccessToken(matchResponse.accessTokenString);
      this.nodeId = matchResponse.nodeId;
      this.usingRelay = matchResponse.usingRelay;
    }

    public MatchInfo(JoinMatchResponse matchResponse)
    {
      this.address = matchResponse.address;
      this.port = matchResponse.port;
      this.networkId = matchResponse.networkId;
      this.accessToken = new NetworkAccessToken(matchResponse.accessTokenString);
      this.nodeId = matchResponse.nodeId;
      this.usingRelay = matchResponse.usingRelay;
    }

    public override string ToString()
    {
      return UnityString.Format("{0} @ {1}:{2} [{3},{4}]", (object) this.networkId, (object) this.address, (object) this.port, (object) this.nodeId, (object) this.usingRelay);
    }
  }
}
