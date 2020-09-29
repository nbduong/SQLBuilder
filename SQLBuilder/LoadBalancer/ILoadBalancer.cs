﻿#region License
/***
 * Copyright © 2018-2020, 张强 (943620963@qq.com).
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * without warranties or conditions of any kind, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
#endregion

using System.Collections.Generic;
using System.Threading.Tasks;
/****************************
* [Author] 张强
* [Date] 2020-09-29
* [Describe] 负载均衡接口
* **************************/
namespace SQLBuilder.LoadBalancer
{
    /// <summary>
    /// 负载均衡接口
    /// </summary>
    public interface ILoadBalancer
    {
        /// <summary>
        /// 获取数据集合中的一条数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">数据集合</param>
        /// <param name="weights">权重集合，仅当实现权重逻辑的实例才有效</param>
        /// <returns></returns>
        T Get<T>(IEnumerable<T> data, int[] weights = null);
    }
}