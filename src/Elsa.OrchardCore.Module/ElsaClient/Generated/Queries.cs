﻿using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace Elsa.OrchardCore
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class Queries
        : global::StrawberryShake.IDocument
    {
        private readonly byte[] _hashName = new byte[]
        {
            109,
            100,
            53,
            72,
            97,
            115,
            104
        };
        private readonly byte[] _hash = new byte[]
        {
            88,
            86,
            68,
            72,
            74,
            78,
            57,
            118,
            66,
            79,
            105,
            67,
            81,
            72,
            111,
            76,
            113,
            111,
            47,
            90,
            114,
            119,
            61,
            61
        };
        private readonly byte[] _content = new byte[]
        {
            113,
            117,
            101,
            114,
            121,
            32,
            103,
            101,
            116,
            87,
            111,
            114,
            107,
            102,
            108,
            111,
            119,
            68,
            101,
            102,
            105,
            110,
            105,
            116,
            105,
            111,
            110,
            115,
            40,
            36,
            118,
            101,
            114,
            115,
            105,
            111,
            110,
            58,
            32,
            86,
            101,
            114,
            115,
            105,
            111,
            110,
            79,
            112,
            116,
            105,
            111,
            110,
            115,
            73,
            110,
            112,
            117,
            116,
            41,
            32,
            123,
            32,
            119,
            111,
            114,
            107,
            102,
            108,
            111,
            119,
            68,
            101,
            102,
            105,
            110,
            105,
            116,
            105,
            111,
            110,
            115,
            40,
            118,
            101,
            114,
            115,
            105,
            111,
            110,
            58,
            32,
            36,
            118,
            101,
            114,
            115,
            105,
            111,
            110,
            41,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            105,
            100,
            32,
            100,
            101,
            102,
            105,
            110,
            105,
            116,
            105,
            111,
            110,
            73,
            100,
            32,
            110,
            97,
            109,
            101,
            32,
            100,
            101,
            115,
            99,
            114,
            105,
            112,
            116,
            105,
            111,
            110,
            32,
            118,
            101,
            114,
            115,
            105,
            111,
            110,
            32,
            105,
            115,
            76,
            97,
            116,
            101,
            115,
            116,
            32,
            105,
            115,
            80,
            117,
            98,
            108,
            105,
            115,
            104,
            101,
            100,
            32,
            105,
            115,
            83,
            105,
            110,
            103,
            108,
            101,
            116,
            111,
            110,
            32,
            105,
            115,
            68,
            105,
            115,
            97,
            98,
            108,
            101,
            100,
            32,
            125,
            32,
            125
        };

        public ReadOnlySpan<byte> HashName => _hashName;

        public ReadOnlySpan<byte> Hash => _hash;

        public ReadOnlySpan<byte> Content => _content;

        public static Queries Default { get; } = new Queries();

        public override string ToString() => 
            @"query getWorkflowDefinitions($version: VersionOptionsInput) {
              workflowDefinitions(version: $version) {
                id
                definitionId
                name
                description
                version
                isLatest
                isPublished
                isSingleton
                isDisabled
              }
            }";
    }
}
