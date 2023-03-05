﻿namespace NewLife.Caching.Clusters;

/// <summary>Redis集群接口。包括主从、哨兵和集群</summary>
public interface IRedisCluster
{
    /// <summary>根据Key选择节点</summary>
    /// <param name="key">键</param>
    /// <param name="write">可写</param>
    /// <returns></returns>
    IRedisNode SelectNode(String key, Boolean write);

    /// <summary>根据异常重选节点</summary>
    /// <param name="key">键</param>
    /// <param name="write">可写</param>
    /// <param name="exception"></param>
    /// <returns></returns>
    IRedisNode ReselectNode(String key, Boolean write, Exception exception);
}