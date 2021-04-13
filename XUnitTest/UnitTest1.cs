using ConsoleApp4;
using System;
using Xunit;

namespace XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void AdditionOperations_12_4and4_1()
        {
            double a = 12.4;
            double b = 4.1;
            //���������� ���������
            double expected = 16.5;
            //������ ������
            Operations operations = new Operations();
            double actual = operations.Addition(a, b);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SubtractionOperations_12_4and4_1()
        {
            double a = 12.4;
            double b = 4.1;
            //���������� ���������
            double expected = 8.3;
            //������ ������
            Operations operations = new Operations();
            double actual = operations.Subtraction(a, b);
            Assert.Equal(expected, actual);
        }
    }
}
